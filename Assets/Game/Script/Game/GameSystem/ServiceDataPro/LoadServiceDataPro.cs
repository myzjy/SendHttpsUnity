using System;
using System.Collections;
using System.Collections.Generic;
using GameData.Net;

namespace GameSystem.ServiceDataPro
{
    /// <summary>
    /// loaing时读取相关数据 没有数据需启动，创建各种api json 启动携程
    /// </summary>
    public class LoadServiceDataPro : BaseServiceData
    {
        private ServericeBase _serverice;
        //用户
        private UserService _Userservice;

        private MasterServiceDataPro m_masterServiceData;

        //启动携程检查数据
        public IEnumerator LoadServerData(Dictionary<string, Type> _types, string path)
        {
            yield break;
        }
    }
}