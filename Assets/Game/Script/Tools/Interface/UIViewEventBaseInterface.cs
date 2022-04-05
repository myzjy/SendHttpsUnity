using System;
using Game.UI.Common;
using UnityEngine;

namespace Game.UI.BaseView
{
    public interface UIViewEventBaseInterface
    {
        void OnUIViewEvent<T>(string Message, T view_obj);

        void OnUIViewEvent<T, TL>(string Message, T view_obj, TL view_objTl);

        void OnUIViewEvent<T, TL, TB>(string Message, T view_obj, TL view_objTl, TB view_objTb);
    }

    public interface UIGetViewInterface
    {
        void OnUIViewEvent<T>(string Message, T view_obj);

        void OnUIViewEvent<T, TL>(string Message, T view_obj, TL view_objTl);

        void OnUIViewEvent<T, TL, TB>(string Message, T view_obj, TL view_objTl, TB view_objTb);
    }
    /// <summary>
    /// 寻找Root接口
    /// </summary>
    public interface RootViewBase
    {
        //
        UIBaseView GetRootView(Transform m_trView);
        
        UIBaseView GetRootView();
        /// <summary>
        /// 根据类型自动找父类的
        /// </summary>
        /// <param name="defaultvalue">类型数值</param>
        /// <param name="_baseFunc">执行事件</param>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        T ApplyRootView<T>(T defaultvalue, Func<UIBaseView, T> _baseFunc);

        BasePageView GetBasePageView();

        void SetRootView(UIBaseView _base);
        
        BasePageView GetBasePageView(Transform m_trView);
        
    }
}