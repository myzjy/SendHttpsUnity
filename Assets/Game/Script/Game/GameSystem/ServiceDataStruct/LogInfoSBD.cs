using GameSystem.ServiceDataVo;

namespace GameSystem.ServiceDataStruct
{
    public class LogInfoSBD
    {
        private LoginSVO m_login;
        private UserSBD m_userdata;
        private TheCatMintFieldDataVo m_theCatMintFieldDataVo;
        private TheCatMintFieldSBD m_theCatMintField;

        /// <summary>
        /// 猫薄荷田
        /// </summary>
        public TheCatMintFieldSBD TheCatMintFieldSbd
        {
            get { return m_theCatMintField; }
        }

        public void CreateUserData(UserSVO mUserdata, IBaseDataTypeFinder finder)
        {
            if (m_userdata == null)
            {
                m_userdata = new UserSBD();
            }

            m_userdata.SetDataVo(mUserdata, finder);
        }

        public UserSBD UserSbd => m_userdata;

        public void SetData(LoginSVO svo, IBaseDataTypeFinder _finder)
        {
            m_login = svo;
            if (m_userdata == null)
            {
                m_userdata = new UserSBD();
            }

            m_userdata.SetDataVo(m_login.user, _finder);
        }

        public void UpdataUser(UserSVO _user, IBaseDataTypeFinder _data)
        {
            m_userdata.SetDataVo(_user, _data);
        }

        //创建出猫薄荷田
        public void CreateTheCatMintFieldData(TheCatMintFieldDataVo _theCatMintField, IBaseDataTypeFinder finder)
        {
            UpDateTheCatMintFileData(_theCatMintField, finder);
        }

        private void UpDateTheCatMintFileData(TheCatMintFieldDataVo _theCatMintField, IBaseDataTypeFinder finder)
        {
            if (m_theCatMintField == null)
            {
                m_theCatMintField = new TheCatMintFieldSBD();
                m_theCatMintField.SetData(_theCatMintField, finder);
            }
            else
            {
                m_theCatMintField.SetData(_theCatMintField, finder);
            }
        }

        private CatnipCollectionSBD m_collectionVo;

        /// <summary>
        /// 采集猫薄荷
        /// </summary>
        public CatnipCollectionSBD CollectionVo
        {
            get { return m_collectionVo; }
        }

        public void CreateCatnipCollectionData(CatnipCollectionVO collectionVo, IBaseDataTypeFinder finder)
        {
            UpDateCatnipCollection(collectionVo, finder: finder);
        }

        private void UpDateCatnipCollection(CatnipCollectionVO collectionVo, IBaseDataTypeFinder finder)
        {
            if (m_collectionVo == null)
            {
                m_collectionVo = new CatnipCollectionSBD();
                m_collectionVo.SetData(collectionVo, finder);
            }
            else
            {
                m_collectionVo.SetData(collectionVo, finder);
            }
        }

        private CatnipLocalDataSBD m_collectionlVo;

        /// <summary>
        /// 猫薄荷
        /// </summary>
        public CatnipLocalDataSBD CollectionlVo
        {
            get { return m_collectionlVo; }
        }

        public void CreateCatnipLocalData(CatnipLocalDataSVo collectionVo, IBaseDataTypeFinder finder)
        {
            UpDateCatnipLocalData(collectionVo, finder: finder);
        }
        
        private void UpDateCatnipLocalData(CatnipLocalDataSVo collectionVo, IBaseDataTypeFinder finder)
        {
            if (m_collectionlVo == null)
            {
                m_collectionlVo = new CatnipLocalDataSBD();
                m_collectionlVo.SetData(collectionVo, finder);
            }
            else
            {
                m_collectionlVo.SetData(collectionVo, finder);
            }
        }
    }
}