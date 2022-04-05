using GameData.Net;
using GameSystem.ServiceDataVo;

namespace GameSystem.ServiceDataPro.Api
{
    public class UserServiceApi:Api<UserService,UserSVO,ServericeBase>
    {
        public UserServiceApi()
        {
            this.Parm=ServericeBase.ServericeBaseGet();
            this.Path = "/api/user/login";
        }
    }
}