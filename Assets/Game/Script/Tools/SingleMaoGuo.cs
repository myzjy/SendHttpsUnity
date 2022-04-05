using System;
using UnityEngine;

// using XLua;

namespace Assets.Script.Tools
{
    /// <summary>
    /// 单例模板
    /// </summary>
    // [LuaCallCSharp]
    public class SingleMaoGuo<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T I;

        private void Awake()
        {
            I = this as T;
            OnAwake();
        }

        /// <summary>
        /// 当前物体是否创建出来
        /// </summary>
        /// <returns></returns>
        public static bool IsNotNull()
        {
            return I != null;
        }

        private static Action _action = null;

        /// <summary>
        /// 是否隐藏当前脚本或者物体
        /// </summary>
        /// <returns></returns>
        public bool IsActive()
        {
            return IsNotNull() && I.gameObject.activeSelf;
        }

        /// <summary>
        /// Awake 启动
        /// </summary>
        protected virtual void OnAwake()
        {
        }

        protected virtual void OnDestroy()
        {
            this.Release();
        }

        protected virtual void Release()
        {
        }
    }

    public class Gir
    {
        public Action _action;
    }
}