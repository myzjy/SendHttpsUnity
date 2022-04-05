using System;
using System.Collections.Generic;
using GameData.Net;
using Tools.Util;

namespace GameSystem.ServiceDataPro
{
    //最主要的读取存放
    public class GameRootServicePro : BaseServiceData
    {
        private ServiceLoad m_serviceLoad = null;
        private MasterServiceDataPro m_masterServiceData = null;
        private UserService m_serviceUser = null;
        private LoadServiceDataPro m_loadService = null;
        private Dictionary<Type, BaseServiceData> m_baseServiceDict = new Dictionary<Type, BaseServiceData>();
        private static readonly string DefaultApiDomainName = "localhost";

        public string ApiDomainName
        {
            get
            {
#if USE_DEBUG_TOOLS
                return DefaultApiDomainName;
#endif
                return "";
            }
        }

        private static int DefaultApiPort
        {
            get
            {
#if !UNITY_EDITOR
                var port = 443;
                switch ("https")
                {
                    case "https":
                        port = 443;
                        break;
                    case "http":
                        port = 80;
                        break;
                }

                return port;
#else
                //默认443端口
                return 443;

#endif
            }
        }

        private string ApiRootHost
        {
            get
            {
#if USE_DEBUG_TOOLS
                return ApiDomainName;
#endif
                return "";
            }
        }

        public GameRootServicePro()
        {
            //初始化new出来
            SetInfoData();
        }

        public void LoadFullMaster(Action onFinsh)
        {
            m_masterServiceData.LoadAllMaster(onFinsh.Execute);
        }

        //进行设置
        private void SetInfoData()
        {
            SetGameLoad(ApiDomainName, DefaultApiPort);
            SetAssetMasetrData();
        }

        private void SetGameLoad(string host, int port)
        {
            if (m_serviceLoad == null)
            {
                m_serviceLoad = new ServiceLoad();
                SetServiceLoad(m_serviceLoad);
            }

            m_serviceLoad.SetURLs(host, port);
        }

        //主要控制
        private void SetAssetMasetrData()
        {
            m_masterServiceData = GetServiceDataPro<MasterServiceDataPro>();
            m_serviceUser = GetServiceDataPro<UserService>();
            m_loadService = GetServiceDataPro<LoadServiceDataPro>();
            m_serviceUser.RequsetLogin(() => { });
        }

        //get到 存放数据
        public T GetServiceDataPro<T>() where T : BaseServiceData, new()
        {
            if (m_baseServiceDict.ContainsKey(typeof(T)))
            {
                return m_baseServiceDict[typeof(T)] as T;
            }

            var service = new T();
            service.SetServiceLoad(m_serviceLoad);
            if (service is MasterUserPro)
            {
                (service as MasterUserPro).ser_serviceData = m_masterServiceData;
            }

            m_baseServiceDict.Add(typeof(T), service);
            return service;
        }
    }
}