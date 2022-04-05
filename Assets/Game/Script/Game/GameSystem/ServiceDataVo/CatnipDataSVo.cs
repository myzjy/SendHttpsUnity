using System;
using ZJY.NetData;

namespace GameSystem.ServiceDataVo
{
    //猫薄荷
    [Serializable]
    public class CatnipLocalDataSVo : LocalDataBase
    {
        /// <summary>
        /// 标题名
        /// </summary>
        public string titleName;

        /// <summary>
        /// 介绍
        /// </summary>
        public string descString;

        /// <summary>
        /// 自身包含猫薄荷
        /// </summary>
        public double catnipLocal;

        /// <summary>
        /// 最大猫薄荷 根据我建造了多少猫薄荷田发生变化
        /// </summary>
        public double catnipMaxLocal;

        /// <summary>
        /// 起始猫薄荷最大库存
        /// </summary>
        public int startCatipMaxLoacl;
    }
}