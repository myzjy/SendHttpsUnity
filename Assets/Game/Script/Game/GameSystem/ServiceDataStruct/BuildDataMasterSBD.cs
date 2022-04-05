using GameSystem.ServiceDataVo;

namespace GameSystem.ServiceDataStruct
{
    public class BuildDataMasterSBD
    {
        // private UserSVO m_userVo;
        /// <summary>
        /// 建筑物 除开基础建筑外
        /// </summary>
        private BuildDataServerVo BuildDataServerVo;

        /// <summary>
        /// 采集猫薄荷建筑物
        /// </summary>
        private CatnipCollectionSBD catnipCollectionSBD;

        /// <summary>
        /// 精炼猫薄荷
        /// </summary>
        private RefinedCatnipLocalDataSBD refinedCatnipLocalDataVo;

        /// <summary>
        /// 带参
        /// </summary>
        /// <param name="m_vo">建筑基础</param>
        /// <param name="finder">查找数据接口</param>
        public BuildDataMasterSBD(BuildDataServerVo m_vo, IBaseDataTypeFinder finder)
        {
            // m_userVo = loginSvo._user;
            BuildDataServerVo = m_vo;
            catnipCollectionSBD = finder.FindBaseData<CatnipCollectionSBD>("catnip_collections");
            refinedCatnipLocalDataVo = finder.FindBaseData<RefinedCatnipLocalDataSBD>("refined_catnip");
        }

        /// <summary>
        /// 采集猫薄荷建筑物
        /// </summary>
        public CatnipCollectionSBD CatnipCollection
        {
            get { return catnipCollectionSBD; }
        }

        /// <summary>
        /// 精炼猫薄荷
        /// </summary>
        public RefinedCatnipLocalDataSBD RefinedCatnipLocalData
        {
            get { return refinedCatnipLocalDataVo; }
        }
    }
}