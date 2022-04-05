using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using GameData.Net;
using GameSystem.ServiceDataStruct;
using GameSystem.ServiceDataVo;
// using MaoguoDll.Server;
using Tools.Util;
using UniRx;
using UnityEngine;
using ZJY.NetData;

namespace GameSystem.ServiceDataPro
{
    using LocalDataBaseDict = Dictionary<Type, LocalDataBase>;
    using LocalDataBasesDict = Dictionary<string, LocalDataBase[]>;

    public class MasterServiceDataPro : BaseServiceData, IBaseDataTypeFinder
    {
        private Func<UniRx.IObserver<Unit>, IEnumerator>[] m_loadIeFunc;
        private readonly LocalDataBaseDict _localDataBase = new LocalDataBaseDict();
        private readonly LocalDataBasesDict _localDataBases = new LocalDataBasesDict();

        public MasterServiceDataPro()
        {
        }

        //我们 数据api /master/具体文件 json文件名
        private readonly Dictionary<string, string> serviceApiName = new Dictionary<string, string>()
        {
            //猫薄荷 
            {"catnip_data_base", "catnip/catnip_data_base"},
            //采集猫薄荷 基础数据
            {"catnip_collection", "catnip/catnip_collection"},
            //猫薄荷田
            {"thecat_mintfield", "catnip/thecat_mintfield"},
            //精炼猫薄荷
            {"refined_catnip", "catnip/refined_catnip"},
            {"dataBase", "data/alldatabase"}
        };

        private void SetUpLoadBaseDataIe()
        {
            // ReSharper disable once RedundantCheckBeforeAssignment
            if (m_loadIeFunc != null) m_loadIeFunc = null;
            var list = new List<Func<UniRx.IObserver<Unit>, IEnumerator>>()
            {
                #region 这几个api接口数据内容，在login的api中已经拉取到了所以不需要了这几个

                #endregion
            };
            m_loadIeFunc = list.ToArray();
        }

        //选择的 携程 转换
        private UniRx.IObservable<Unit> SelectCoroutine(Func<UniRx.IObserver<Unit>, IEnumerator> cororoutine) =>
            Observable.FromCoroutine(cororoutine);

        public void LoadAllMaster(Action onFinsh)
        {
            RequesLoadResouresAllMaster(onFinsh);
        }

        private void RequesLoadResouresAllMaster(Action onFinsh)
        {
            StartUpLoadIe().ObserveOnMainThread().Subscribe(_ => onFinsh.Execute());
        }

        private UniRx.IObservable<Unit> StartUpLoadIe()
        {
            SetUpLoadBaseDataIe();
            //选择出我可以执行的 读取资源携程
            return m_loadIeFunc.Select(SelectCoroutine).WhenAll();
        }

        private void RequestLoadMasterData<T>(string m_name, Action<T> resData)
        {
            // RequesServiceJson($"api/get/{m_name}", resData);
        }

        #region 基础数据 携程

        private IEnumerator LoadCatnipCollectionAssetJson(UniRx.IObserver<Unit> observer)
        {
            //name
            string masterName = serviceApiName["catnip_collection"];

            yield return ServiceMasterData<CatnipCollectionVO>(observer, item => item, masterName);
        }

        #endregion

        #region 根据urlname取得数据 数据库内容不放本地

        //拿到基础相关数据
        private IEnumerator ServiceMasterData<T>(UniRx.IObserver<Unit> observer, Func<T, T> _func, string urlName)
            where T : LocalDataBase
        {
            bool isLoad = false;
            RequesServiceJson<T>(urlName: "api/" + urlName, res =>
            {
                var datas = _func(res);

                AddServiceMasterData(datas.GetType(), datas);
                isLoad = false;
            });
            yield return new WaitUntil(()=>isLoad);
            Finish(observer, "");
        }

        private IEnumerator ServiceMasterData<Tclass, T>(UniRx.IObserver<Unit> observable,
            Func<Tclass, T[]> getMasters, string urlName)
            where Tclass : class
            where T : LocalDataBase
        {
            bool isLoad = false;
            RequesServiceJson<Tclass>(urlName: "api/" + urlName, res =>
            {
                var datas = getMasters(res);

                AddServiceMasterDatas(datas.GetType().Name, datas);
                isLoad = true;
            });
            yield return new WaitUntil(() => isLoad);
            Finish(observable, "");
        }

        /// <summary>
        /// 启动对应响应事件
        /// </summary>
        /// <param name="observer">响应的事件</param>
        /// <param name="error">是否有错误消息</param>
        private void Finish(UniRx.IObserver<Unit> observer, string error)
        {
            if (!string.IsNullOrEmpty(error))
            {
                //弹出报错消息
                observer.OnError(new Exception(error));
            }
            else
            {
                //转换执行接下来事件
                observer.OnNext(Unit.Default);
            }

            //正式启动 响应事件 
            observer.OnCompleted();
        }

        //根据api，存储位置
        private void RequesServiceMaster<T>(string urlName, Action<T> _urlAction) where T : class, new()
        {
            ServericeBase servericeBase = CreateGet();
            // servericeBase.SetTypeData<T>(new T());
            //get 到dll中存储的json数据
            RequesServiceJson($"api/master/{urlName}",
                _base: servericeBase,
                _cl: _urlAction);
        }

        //添加
        public void AddServiceMasterDatas<T>(string dataName, T[] _datas) where T : LocalDataBase
        {
            if (_localDataBases.ContainsKey(dataName))
            {
                _localDataBases[dataName] = _datas;
            }
            else
            {
                _localDataBases.Add(dataName, _datas);
            }
        }

        //添加
        public void AddServiceMasterData<T>(Type dataName, T _datas) where T : LocalDataBase
        {
            // m_gameDataBase.CreateMasterData<T>($"api/master/{dataName}.json", dataName);
            if (_localDataBase.ContainsKey(dataName))
            {
                _localDataBase[dataName] = _datas;
            }
            else
            {
                _localDataBase.Add(dataName, _datas);
            }
        }

        private object GetMasterData(Type _type)
        {
            return _localDataBase.ContainsKey(_type) ? _localDataBase[_type] : null;
        }

        #endregion

        private Dictionary<string, ServiceBaseData> ServiceBasesDict = new Dictionary<string, ServiceBaseData>();

        private T GetBaseValueData<T>(string classCode) where T : ServiceBaseData
        {
            return ServiceBasesDict.ContainsKey(classCode) ? ServiceBasesDict[classCode] as T : null;
        }

        private void AddServiceBaseData(string code, ServiceBaseData _service)
        {
            ServiceBasesDict.Add(code, _service);
        }

        public T FindBaseData<T>(string classCode) where T : ServiceBaseData, new()
        {
            if (ServiceBasesDict.ContainsKey(classCode))
            {
                return GetBaseValueData<T>(classCode);
            }

            var res = new T();

            var type = res.TypeOfDt;
            var data = GetMasterData(type) as LocalDataBase;
            AddServiceBaseData(classCode, res);
            res.SetData(data, this);
            return res;
            // throw new NotImplementedException();
        }

        public T[] FindBaseDatas<T>(string classCode, string keyValue) where T : ServiceBaseData, new()
        {
            throw new NotImplementedException();
        }
    }
}