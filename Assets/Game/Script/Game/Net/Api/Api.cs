using System;
using GameData.Net;
using ZJY.NetData;

namespace GameSystem.ServiceDataPro.Api
{
    public class Api<TRequest, TResponse, TServericeBase>
        where TRequest : MasterUserPro
        where TResponse : LocalDataBase
        where TServericeBase : ServericeBase
    {
        public TRequest Data { get; set; }
        public TServericeBase Parm { get; protected set; }
        public string Path { get; protected set; }
        public Action onBeforeSend;
        public Action<TResponse> onSuccess;
        public Action onComplete;
    }
}