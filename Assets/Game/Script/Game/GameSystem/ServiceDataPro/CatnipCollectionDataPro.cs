using System;
using GameData.Net;
using GameSystem.ServiceDataStruct;
using GameSystem.ServiceDataVo;
// using JetBrains.Annotations;
// using MaoguoDll.Server;
using Tools.Util;

namespace GameSystem.ServiceDataPro
{
    /// <summary>
    /// 采集猫薄荷 
    /// </summary>
    public class CatnipCollectionDataPro : MasterUserPro
    {
        /// <summary>
        /// 采集猫薄荷
        /// </summary>
        public CatnipCollectionSBD _Collection { get; private set; }

        /// <summary>
        /// 猫薄荷
        /// </summary>
        public CatnipLocalDataSBD m_catnipLocalDataSBD { get; private set; }

        public TheCatMintFieldSBD m_theCatMintFieldSBD { get; private set; }

        public void SetCatnipColloection(CatnipCollectionSBD _catnip)
        {
            this._Collection = _catnip;
        }

        public void SetCatnipColloection(CatnipLocalDataSBD _catnip)
        {
            this.m_catnipLocalDataSBD = _catnip;
        }

        public void SetTheCatMintFieldSBD(TheCatMintFieldSBD _theCatMint)
        {
            this.m_theCatMintFieldSBD = _theCatMint;
        }

        public void RequestCatnipJson(Action<CatnipLocalDataSVo> finsh)
        {
            ServericeBase m_servericeBase = ServericeBase.ServericeBasePost();

            m_servericeBase.AddPayload("add_catnip", _Collection.ClickCatnipNum);
            //点击采集猫薄荷
            RequesServiceJson<CatnipLocalDataSVo>("api/catnip/catnip_data_base",m_servericeBase, finsh);
        }
        public void GetRequestCatnipJson(Action<CatnipLocalDataSVo> finsh)
        {
            ServericeBase m_servericeBase = ServericeBase.ServericeBaseGet();
            //采集猫薄荷
            RequesServiceJson<CatnipLocalDataSVo>("api/catnip/catnip_data_base",m_servericeBase, finsh);
        }

        //刷新数据 更新
        public void UpData()
        {
            GetRequestCatnipJson(res =>
            {
                if (_Collection != null)
                {
                    _Collection.SetData(res,BaseDataTypeFinder);
                }
            });
        }
    }
}