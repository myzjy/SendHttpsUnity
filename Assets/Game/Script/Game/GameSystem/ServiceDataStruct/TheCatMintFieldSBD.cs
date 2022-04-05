using System;
using GameSystem.ServiceDataVo;
using ZJY.NetData;

namespace GameSystem.ServiceDataStruct
{
    public class TheCatMintFieldSBD : ServiceData<TheCatMintFieldDataVo>
    {
        public override void SetData(LocalDataBase localDataCv, IBaseDataTypeFinder Ifinder)
        {
            base.SetData(localDataCv, Ifinder);
        }

        public int NowTheCatMintFieldNum
        {
            get { return m_data.nowTheCatMintFieldNum; }
        }

        public double StartTheCatMintFieldNum
        {
            get { return m_data.startTheCatMintFieldNum; }
        }

        public bool IsLock
        {
            get { return m_data.mLock > 0 ? true : false; }
        }

        public double TheCatMintPrice
        {
            get { return m_data.theCatMintPrice; }
        }

        public double TheCatMintFieldEffect
        {
            get { return m_data.theCatMintFieldEffect; }
        }
    }
}