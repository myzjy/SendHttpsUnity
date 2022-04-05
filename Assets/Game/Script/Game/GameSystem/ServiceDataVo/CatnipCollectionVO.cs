using System;
using ZJY.NetData;

namespace GameSystem.ServiceDataVo
{
  
    //采集猫薄荷
    [Serializable]
    public class CatnipCollectionVO : LocalDataBase
    {
        /// <summary>
        /// 点击一次采集获得猫薄荷数量
        /// </summary>
        public int ClickCatnipNum = 1; //点击一次采集获得猫薄荷数量

        /// <summary>
        /// 标题名
        /// </summary>
        public string titleName; //标题名


        /// <summary>
        /// 介绍
        /// </summary>
        public string message;
    }
}