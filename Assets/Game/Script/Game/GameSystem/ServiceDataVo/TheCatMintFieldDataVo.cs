using System;
using ZJY.NetData;

namespace GameSystem.ServiceDataVo
{
    //猫薄荷田
    [Serializable]
    public class TheCatMintFieldDataVo:  LocalDataBase
    {
        /// <summary>
        /// 当前建造的猫薄荷田数量
        /// </summary>
        public int nowTheCatMintFieldNum;

        /// <summary>
        /// 是否解锁 0未解锁 1解锁
        /// </summary>
        public int mLock;

        /// <summary>
        /// 起始花费
        /// </summary>
        public double startTheCatMintFieldNum;

        /// <summary>
        /// 价格倍率 
        /// </summary>
        public double theCatMintPrice;

        /// <summary>
        /// 起始猫薄荷每秒增长
        /// </summary>
        public double theCatMintFieldEffect;
    }
}