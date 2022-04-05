using System;
using System.Collections;
using System.Collections.Generic;
using Game.GameSystem;
using UnityEngine;

namespace ZJY.NetData
{
    /// <summary>
    /// 用于继承 数据基础类
    /// </summary>
    [Serializable]
    public  class LocalDataBase:ModelDatraIn
    {
        // public 
    }


    public abstract class DataBase
    {
        /// <summary>
        /// 等级
        /// </summary>
        public int Lv { get; set; }

        /// <summary>
        /// 当前数据
        /// </summary>
        public double data_num { get; set; }

        /// <summary>
        /// 猫国人口 领袖成长黄金需求 计算
        /// </summary>
        public virtual int SetCoinData()
        {
            return 0;
        }

        /// <summary>
        /// 人口领袖的经验需求
        /// </summary>
        /// <returns></returns>
        public virtual uint GetExpData()
        {
            return 0;
        }

        /// <summary>
        /// 领袖的工作效率
        /// </summary>
        /// <returns></returns>
        public virtual double GetWorkEfficiency()
        {
            return 0;
        }

        /// <summary>
        /// 设置相关数据
        /// </summary>
        public virtual void SetData()
        {
        }
    }
}