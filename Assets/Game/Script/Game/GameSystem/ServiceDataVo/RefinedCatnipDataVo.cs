using System;
using ZJY.NetData;

namespace GameSystem.ServiceDataVo
{
    //精炼猫薄荷
    [Serializable]
    public class RefinedCatnipLocalDataVo:LocalDataBase
    {
        public int expendNum; //点击花费
        public int gainNum;//点击获得
    }
}