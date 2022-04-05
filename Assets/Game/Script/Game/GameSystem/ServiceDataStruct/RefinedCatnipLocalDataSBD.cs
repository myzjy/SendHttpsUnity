using GameSystem.ServiceDataVo;
using ZJY.NetData;

namespace GameSystem.ServiceDataStruct
{
    public class RefinedCatnipLocalDataSBD : ServiceData<RefinedCatnipLocalDataVo>
    {
        public override void SetData(LocalDataBase localDataCv, IBaseDataTypeFinder Ifinder)
        {
            base.SetData(localDataCv, Ifinder);
        }

        public int ExpendNum
        {
            get
            {
                return m_data.expendNum;
            }
        } //点击花费

        public int GainNum
        {
            get
            {
                return m_data.gainNum;
            }
        }
    }
}