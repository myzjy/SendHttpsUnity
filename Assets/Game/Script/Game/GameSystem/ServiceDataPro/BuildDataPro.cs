using System;
using GameSystem.ServiceDataStruct;
using GameSystem.ServiceDataVo;
using Tools.Util;

namespace GameSystem.ServiceDataPro
{
    /// <summary>
    /// 建筑 pro
    /// </summary>
    public class BuildDataPro : MasterUserPro
    {
        private BuildDataMasterSBD m_BuildMaster;

        /// <summary>
        /// 建筑
        /// </summary>
        /// <param name="_lngInf"></param>
        public void RequestBuildData(Action<BuildDataMasterSBD> onComplte)
        {
            // var server = CreateGet();
            // RequestJsonOnThread<BuildDataServerVo>("api/master/AllBuildData", server,
            //     res => { m_BuildMaster = new BuildDataMasterSBD(res, BaseDataTypeFinder); },
            //     () => { onComplte.Execute(m_BuildMaster); });
        }
    }
}