using System;
using GameData.Net;
using GameSystem.ServiceDataPro.Api;
using Tools.Util;
using UnityEngine;
using ZJY.NetData;

namespace GameSystem.ServiceDataPro
{
    public class BaseServiceData
    {
        private ServiceLoad _serviceLoad = null;

        protected ServericeBase CreateGet()
        {
            return ServericeBase.ServericeBaseGet();
        }

        protected ServericeBase CreatePos()
        {
            return ServericeBase.ServericeBasePost();
        }

        public void SetServiceLoad(ServiceLoad serviceLoad)
        {
            _serviceLoad = serviceLoad;
        }

        #region 不带api模板 需要具体api 路径

        protected void RequesServiceJson<T>(string urlName, Action<T> _cl)
        {
            Debug.Log($"{urlName}");
            ServericeBase _base = CreateGet();
            // _base.SetTypeData(new T());
            _serviceLoad.ServiceSaveLoadJson<T>(urlName, _base, _cl.Execute);
        }

        protected void RequesServiceJson<T>(string urlName, ServericeBase _base, Action<T> _cl)
        {
            _serviceLoad.ServiceSaveLoadJson<T>(urlName, _base, _cl.Execute);
        }

        #endregion

        #region 带api模板

        protected void RequesServiceJson<TS, T, T2>(Api<TS, T, T2> _api)
            where TS : MasterUserPro
            where T : LocalDataBase
            where T2 : ServericeBase
        {
            Debug.Log($"{_api.Path}");
            // _base.SetTypeData(new T());
            _serviceLoad.ServiceSaveLoadJson(_api);
        }

        protected void RequestJsonOnThread<TS, T, T2>(Api<TS, T, T2> _api)
            where TS : MasterUserPro
            where T : LocalDataBase
            where T2 : ServericeBase
        {
            _serviceLoad.ServiceLoadJsonBgThread(_api, re => { });
        }

        #endregion
    }
}