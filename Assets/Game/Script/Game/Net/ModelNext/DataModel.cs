using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using WJFramework;

namespace GameData.Net
{
    public class BaseNetData
    {
        private ServericeBase m_server = null;

        protected ServericeBase CreateGetServericeBase()
        {
            return ServericeBase.ServericeBaseGet();
        }
        protected ServericeBase CreatePostServericeBase()
        {
            return ServericeBase.ServericeBasePost();
        }
        public void RequestJson<T>(string qeuestName,ServericeBase _serverice, Action<T> success)
        {
            
        }
    }
}