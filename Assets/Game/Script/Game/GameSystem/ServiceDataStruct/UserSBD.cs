using GameSystem.ServiceDataVo;

namespace GameSystem.ServiceDataStruct
{
    public class UserSBD
    {
        private UserSVO m_userVo;

        public void SetDataVo(UserSVO _svo, IBaseDataTypeFinder finder)
        {
            m_userVo = _svo;
        }
    }
}