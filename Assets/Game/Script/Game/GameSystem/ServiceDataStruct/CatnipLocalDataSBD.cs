using System;
using Game.Manager.Message;
using GameSystem.ServiceDataVo;
using ZJY.NetData;

namespace GameSystem.ServiceDataStruct
{
    //猫薄荷
    public class CatnipLocalDataSBD : ServiceData<CatnipLocalDataSVo>
    {
        //采集猫薄荷
        private CatnipCollectionSBD _catnipCollection;

        public override void SetData(LocalDataBase localDataCv, IBaseDataTypeFinder Ifinder)
        {
            base.SetData(localDataCv, Ifinder);
            //基础数据不会发生任何变化的可以Find
            _catnipCollection = Ifinder.FindBaseData<CatnipCollectionSBD>("catnip_collection");
        }

        public Message TitleName
        {
            get { return (Message) Enum.Parse(typeof(Message), m_data.titleName); }
        }

        public Message DescString
        {
            get
            {
                return (Message) Enum.Parse(typeof(Message), m_data.descString);
            }
        }
        /// <summary>
        /// 自身包含猫薄荷
        /// </summary>
        public double CatnipLocal
        {
            get { return m_data.catnipLocal; }
        }

        /// <summary>
        /// 最大猫薄荷 根据我建造了多少猫薄荷田发生变化
        /// </summary>
        public double CatnipMaxLocal
        {
            get { return m_data.catnipMaxLocal; }
        }

        /// <summary>
        /// 起始猫薄荷最大库存
        /// </summary>
        public int StartCatipMaxLoacl
        {
            get { return m_data.startCatipMaxLoacl; }
        }
    }
}