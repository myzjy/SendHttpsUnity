using System;
using System.Collections;
using System.IO;
using System.Text;
using GameSystem.ServiceDataPro;
using GameSystem.ServiceDataPro.Api;
using GameSystem.ServiceDataVo;
// using MaoguoDll.Server;
using Newtonsoft.Json;
using Tools.Util;
using UniRx;
using UnityEngine;
using ZJY.NetData;

namespace GameData.Net
{
    //这个读取使用过程中数据
    public class ServiceLoad
    {
        //游戏进入创建
        public void SetURLs(string apiHost, int portNo)
        {
            HostManager.Instance.SetURLs(apiHost, portNo);
        }

        #region 保存 需要处理

        #region 不带api模板

        private void ServiceLoadJson<T>(string urlName, ServericeBase _SiBase,
            Action<T> _succes)
        {
            SendRequests<T>(urlName, _SiBase, res =>
            {
                Util.PerformOnBgThread(_succes.Execute, () =>
                {
                    var json = res.DataAssetText;
                    return JsonConvert.DeserializeObject<T>(json);
                });
            }, (bo) => { });
            // _succes.Executes(()=> _actionModel.Invoke(model));
        }

        public void ServiceSaveLoadJson<T>(string urlJsonName, ServericeBase _serverice, Action<T> _succes)
        {
            Debug.Log($" urlJsonName--->{urlJsonName}");

            // string url = string.Format(urlJsonName, _serverice.Methods);
            //以下是在有能读到json的情况下执行
            ServiceLoadJson<T>(urlName: urlJsonName, _SiBase: _serverice, data =>
            {
                Debug.LogError($"{data}");
                //传递
                _succes.Execute(data);
            });
        }

        //保存读取
        public void ServiceLoadJsonBgThread<T>(string urlName, ServericeBase _SiBase, Action<T> _succes, Action finish,
            Action<bool> isAbort)
        {
            Debug.Assert(_succes != null);
            var onComplte = new Action<string>(json =>
            {
                try
                {
                    var data = JsonConvert.DeserializeObject<T>(json);
                    _succes.Execute(data);
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.Log($"{urlName} not json");
                    throw;
                }
            });
            SendRequests<T>(urlName, _SiBase, res =>
            {
                Util.PerformOnBgThread(() =>
                {
                    var json = res.DataAssetText;
                    onComplte.Execute(json);
                }, finish);
            }, isAbort);
        }


        public void ServiceSaveLoadJsonBgThread<T>(string urlJsonName, ServericeBase _serverice, Action<T> _succes,
            Action finsh)
        {
            // string url = string.Format(urlJsonName, _serverice.Methods);
            //以下是在有能读到json的情况下执行
            ServiceLoadJsonBgThread<T>(urlName: urlJsonName, _SiBase: _serverice,
                data =>
                {
                    Debug.LogError($"{data}");
                    //传递
                    _succes.Execute(data);
                }, finsh, re => { });
        }

        private void SendRequests<T>(string urlName, ServericeBase _SiBase, Action<HttpResponse> _succes,
            Action<bool> finish)
        {
            RequestOperationBase httpsRequest = new RequestOperationBase(_SiBase.Methods, urlName);
            httpsRequest._SuccessCallBack = (response, _) =>
            {
#if OUTPUT_API_JSONS
                var data = "";
                try
                {
                    data = Encoding.UTF8.GetString(response.RawData);
                }
                catch (Exception e)
                {
                    Debug.LogError($"boby error-->{e}");
                }

#if UNITY_EDITOR
                Debug.Log($"[HttpsResponse] {urlName}\n{data}");
#endif
#endif
                if (_SiBase.NeedsRetry)
                {
                    _succes.Execute(response);
                }
                else
                {
                    _succes.Execute(response);
                }
            };
            httpsRequest._FailureCallBack = (respone, _) =>
            {
                //出现问题时
                InvokeFailureError(urlName, _SiBase, respone, _succes, finish);
            };
            _SiBase.SetupRequestOperation(httpsRequest);
            httpsRequest.Send();
        }

        #endregion

        #region 带api模板

        public void ServiceSaveLoadJsonBgThread<TS, T, T2>(Api<TS, T, T2> _api)
            where TS : MasterUserPro
            where T : LocalDataBase
            where T2 : ServericeBase
        {
            // string url = string.Format(urlJsonName, _serverice.Methods);
            //以下是在有能读到json的情况下执行
            ServiceLoadJsonBgThread(_api, re => { });
        }

        //读取保存
        public void ServiceSaveLoadJson<TS, T, T2>(Api<TS, T, T2> _api)
            where TS : MasterUserPro
            where T : LocalDataBase
            where T2 : ServericeBase
        {
            Debug.Log($" urlJsonName--->{_api.Path}");

            // string url = string.Format(urlJsonName, _serverice.Methods);
            //以下是在有能读到json的情况下执行
            ServiceLoadJson(_api);
        }


        private void ServiceLoadJson<TS, T, T2>(Api<TS, T, T2> _api)
            where TS : MasterUserPro
            where T : LocalDataBase
            where T2 : ServericeBase
        {
            SendRequests<T>(_api.Path, _api.Parm, res =>
            {
                Util.PerformOnBgThread(_api.onSuccess, () =>
                {
                    var json = res.DataAssetText;
                    return JsonConvert.DeserializeObject<T>(json);
                });
            }, (bo) => { });
            // _succes.Executes(()=> _actionModel.Invoke(model));
        }


        //保存读取
        public void ServiceLoadJsonBgThread<TS, T, T2>(Api<TS, T, T2> _api,
            Action<bool> isAbort)
            where TS : MasterUserPro
            where T : LocalDataBase
            where T2 : ServericeBase
        {
            Debug.Assert(_api.onSuccess != null);
            var onComplte = new Action<string>(json =>
            {
                try
                {
                    var data = JsonConvert.DeserializeObject<T>(json);
                    _api.onSuccess.Execute(data);
                    // _succes.Execute(data);
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.Log($"{_api.Path} not json");
                    throw;
                }
            });
            SendRequests<T>(_api.Path, _api.Parm, res =>
            {
                Util.PerformOnBgThread(() =>
                {
                    var json = res.DataAssetText;
                    onComplte.Execute(json);
                }, _api.onComplete);
            }, isAbort);
        }

        #endregion


        private void InvokeFailureError(string urlpath, ServericeBase _SiBase, HttpResponse _https,
            Action<HttpResponse> _succes,
            Action<bool> finish)
        {
            //web api 出错code
            var errorcod = _https?.StatusCode ?? -1;
            //传递过来数据
            var text = _https?.DataAssetText ?? String.Empty;

            var errorMessage = string.Empty;

            if (!string.IsNullOrEmpty(text) && text.StartsWith("{") && text.EndsWith("}") && text.Contains("error"))
            {
                //错误报告
                var errorc = JsonConvert.DeserializeObject<ErrorApi>(text);
                //解析出错误
                errorMessage = errorc.error;
            }

            if (_https != null)
            {
                var appErrorCode = _https.FindFirstHeaderValue("X-App-Error-Code");
                if (appErrorCode.StartsWith("900"))
                {
                }
            }
            //时间


            //客户端请求错误？
            finish.Execute(errorcod == 404);
        }

        [Serializable]
        public class ErrorApi
        {
            public string error = "";
        }


        private string PathJson =
#if UNITY_EDITOR
            Application.streamingAssetsPath + "/";
#elif UNITY_ANDROID
#elif UNITY_IPHONE
#elif !UNITY_EDITOR
#endif
//         private void SendRequestJson(string urlJson, string json, ServericeBase _serverice)
//         {
//             //根据此去保存
//             // var stJson = urlJson + ":" + _serverice.Methods.ToString();
//             var _json =
// #if UNITY_EDITOR
//                 //编辑器的话保存在本机
//                 $"{PathJson}{urlJson}.json";
//             //先读 没有就根据类型创建出json
//             CreateRequstUrlJson(_json, json);
// #elif UNITY_ANDROID
//             // 其他保存方法
//             //先读 没有就根据类型创建出json
// #elif UNITY_IPHONE
//             // 其他保存方法
//             //先读 没有就根据类型创建出json
// #elif !UNITY_EDITOR&&!UNITY_ANDROID&&!UNITY_IPHONE
//             //其他保存方法
//             //先读 没有就根据类型创建出json
//
// #endif
//         }
//
//         private string SendRequestJson(string urlJson, ServericeBase _serverice)
//         {
//             //根据此去保存
//             // var stJson = urlJson + ":" + _serverice.Methods.ToString();
//             var _json =
// #if UNITY_EDITOR
//                 //编辑器的话保存在本机
//                 $"{PathJson}{urlJson}.json";
//             return ReadText(_json);
// #elif UNITY_ANDROID
//             // 其他保存方法
//             //先读 没有就根据类型创建出json
// #elif UNITY_IPHONE
//             // 其他保存方法
//             //先读 没有就根据类型创建出json
// #elif !UNITY_EDITOR&&!UNITY_ANDROID&&!UNITY_IPHONE
//             //其他保存方法
//             //先读 没有就根据类型创建出json
//
// #endif
//         }
//
//         /// <summary>
//         /// 保存
//         /// </summary>
//         /// <param name="urlJson">路径</param>
//         private void CreateRequstUrlJson(string urlJson, string json)
//         {
//             var dir = Path.GetDirectoryName(urlJson);
//             if (!Directory.Exists(dir))
//             {
//                 if (dir != null) Directory.CreateDirectory(dir);
//             }
//
//             using (var fs = new FileStream(path: urlJson, FileMode.Create))
//             {
//                 using (var writer = new StreamWriter(fs))
//                 {
//                     //写入
//                     writer.Write(json);
//                 }
//             }
//         }
//
//         public string ReadText(string path)
//         {
//             using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
//             {
//                 using (var reader = new StreamReader(fileStream))
//                 {
//                     return reader.ReadToEnd();
//                 }
//             }
//         }

        #endregion
    }
}