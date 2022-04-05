using System;
using Newtonsoft.Json;
using ZJY.NetData;

namespace GameSystem.ServiceDataStruct
{
    public abstract class ServiceBaseData
    {
        /// <summary>
        /// 继承之后T --->Type类型 TypeOf(T) T-->脚本
        /// </summary>
        public abstract Type TypeOfDt { get; }

        /// <summary>
        /// 设置自身数据
        /// </summary>
        /// <param name="localDataCv"></param>
        /// <param name="Ifinder"></param>
        public abstract void SetData(LocalDataBase localDataCv, IBaseDataTypeFinder Ifinder);

        //类型名
        public virtual string Name
        {
            get { return ""; }
        }
    }

    public abstract class ServiceData<T> : ServiceBaseData where T : LocalDataBase
    {
        protected T m_data;

        public override Type TypeOfDt
        {
            get { return typeof(T); }
        }

        public override void SetData(LocalDataBase localDataCv, IBaseDataTypeFinder Ifinder)
        {
            //传递参数转换T类型
            m_data = localDataCv as T;
        }

        protected E ToEnumType<E>(int value)
        {
            return (E) Enum.ToObject(typeof(E), value);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(m_data);
        }
    }
}