using System;

namespace GameSystem.ServiceDataVo
{
    // 登录 可能目前不会用到 只会直接用到UserSvo类
    [Serializable]
    public class LoginSVO
    {
        //目前用户数据
        public UserSVO user;
    }
}