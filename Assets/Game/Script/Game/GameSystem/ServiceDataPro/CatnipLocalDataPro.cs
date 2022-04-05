using GameData.Net;
using GameSystem.ServiceDataStruct;
using GameSystem.ServiceDataVo;

namespace GameSystem.ServiceDataPro
{
    //猫薄荷
    public class CatnipLocalDataPro : MasterUserPro
    {
        /// <summary>
        /// 采集猫薄荷
        /// </summary>
        private CatnipCollectionSBD m_CatnipCollectionSBD;

        /// <summary>
        /// 猫薄荷
        /// </summary>
        private CatnipLocalDataSBD m_catnipLocalDataSBD;

        private TheCatMintFieldSBD m_theCatMintFieldSBD;

        public void SetCatnipLocalData(CatnipLocalDataSBD _catnip)
        {
            this.m_catnipLocalDataSBD = _catnip;
        }

        public void SetCatnipColloection(CatnipCollectionSBD _catnip)
        {
            this.m_CatnipCollectionSBD = _catnip;
        }

        public void SetTheCatMintField(TheCatMintFieldSBD _catnip)
        {
            this.m_theCatMintFieldSBD = _catnip;
        }

        private void CreateCatnipColloection(CatnipLocalDataSVo mCatnipLocalDataSVo, IBaseDataTypeFinder finder)
        {
        }

        public void ServiceMasterData(string urlName)
        {
            ServericeBase mserverice = ServericeBase.ServericeBaseGet();
            // mserverice.AddPayload();
            // RequestJsonOnThread<CatnipLocalDataSVo>(urlName: "api/master/catnip/catnip_data_base", res =>
            // {
            //     // var datas = _func(res);
            // });
        }
    }
}