using System;
using Game.Manager.Message;
using GameSystem.ServiceDataVo;
using ZJY.NetData;

namespace GameSystem.ServiceDataStruct
{
    public class CatnipCollectionSBD : ServiceData<CatnipCollectionVO>
    {
        public override void SetData(LocalDataBase localDataCv, IBaseDataTypeFinder Ifinder)
        {
            base.SetData(localDataCv, Ifinder);
        }

        /// <summary>
        /// 点击一次采集获得猫薄荷数量
        /// </summary>
        public int ClickCatnipNum
        {
            get { return m_data.ClickCatnipNum; }
        }

        /// <summary>
        /// 标题名
        /// </summary>
        private Message TitleName
        {
            get { return (Message) Enum.Parse(typeof(Message), m_data.titleName); }
        }

        /// <summary>
        /// 介绍
        /// </summary>
        public Message Message
        {
            get { return (Message) Enum.Parse(typeof(Message), m_data.message); }
        }

        /// <summary>
        /// 名字
        /// </summary>
        public override string Name
        {
            get { return MessageManager.IsNotNull() ? MessageManager.I.GetMessage(TitleName) : "null"; }
        }
    }
}