using System;
using UnityEngine.Serialization;
using ZJY.NetData;

namespace GameSystem.ServiceDataVo
{
    //用户
    [Serializable]
    public class UserSVO:LocalDataBase
    {
        /// <summary>
        /// 采集猫薄荷建筑物
        /// </summary>
        public CatnipCollectionVO catnipCollection;
        
        /// <summary>
        /// 精炼猫薄荷
        /// </summary>
        public RefinedCatnipLocalDataVo refinedCatnipLocalData;

    }
}