using System;
using ZJY.NetData;

namespace GameSystem.ServiceDataStruct
{
    /// <summary>
    /// 内容一般为查找 指定T类型的类 并new 接口
    /// </summary>
    public interface IBaseDataTypeFinder
    {
        /// <summary>
        /// 根据code查找到具体T类型控制类
        /// </summary>
        /// <param name="classCode">code代码</param>
        /// <typeparam name="T">类型脚本</typeparam>
        /// <returns></returns>
        T FindBaseData<T>(string classCode) where T : ServiceBaseData,new();

        T[] FindBaseDatas<T>(string classCode, string keyValue) where T : ServiceBaseData,new();

        void AddServiceMasterData<T>(Type dataName, T _datas) where T : LocalDataBase;
        void AddServiceMasterDatas<T>(string dataName, T[] _datas) where T : LocalDataBase;
    }
}