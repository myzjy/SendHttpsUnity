using System;
using System.Collections;
using System.IO;
using Game.UI.Common;
using Tools.Util;
using UniRx;
using UnityEngine;

namespace Game.UI.BaseView
{
    //基础显示UI类 一些ui打开事件存储
    public class UIBaseView : MonoBehaviour, RootViewBase
    {
        //ui父类
        private UIBaseView m_UIBaseView = null;

        #region 事件调度 ui显示

        public void DispatchUIViewEvent()
        {
        }

        public void DispatchUIViewEvent(string ui_message)
        {
            DispatchUIViewEvent(ui_message, this);
        }

        protected void DispatchUIViewEvent<T>(string UI_Message, T t_Obj)
        {
            DispatchEventUIRecursively(this.transform, UI_Message, t_Obj);
        }

        protected void DispatchUIViewEvent<TS, TL>(string UI_Message, TS _ts, TL _tl)
        {
            DispatchEventUIRecursively(this.transform, UI_Message, _ts, _tl);
        }

        protected void DispatchUIViewEvent<TS, TL, TN>(string UI_Message, TS _ts, TL _tl, TN _tn)
        {
            DispatchEventUIRecursively(this.transform, UI_Message, _ts, _tl, _tn);
        }

        #region 根据调用分派相关事件，只有经过add添加事件之后才会调用成功，add方法在另外一个基础页面类中。

        private void DispatchEventUIRecursively<T>(Transform _transform, string UI_Message, T _t)
        {
            if (_transform.parent == null) return;
            //隐式转换
            var lr = (UIViewEventBaseInterface) _transform.parent.GetComponent(typeof(UIViewEventBaseInterface));
            if (lr != null)
            {
                lr.OnUIViewEvent(UI_Message, _t);
                return;
            }

            DispatchEventUIRecursively(_transform.parent, UI_Message, _t);
        }

        private void DispatchEventUIRecursively<T, TL>(Transform _transform, string UI_Message, T _t, TL _tl)
        {
            if (_transform.parent == null) return;
            //隐式转换
            var lr = (UIViewEventBaseInterface) _transform.parent.GetComponent(typeof(UIViewEventBaseInterface));
            if (lr != null)
            {
                lr.OnUIViewEvent(UI_Message, _t, _tl);
                return;
            }

            DispatchEventUIRecursively(_transform.parent, UI_Message, _t, _tl);
        }

        private void DispatchEventUIRecursively<T, TL, TB>(Transform _transform, string UI_Message, T _t, TL _tl,
            TB _tb)
        {
            if (_transform.parent == null) return;
            //隐式转换
            var lr = (UIViewEventBaseInterface) _transform.parent.GetComponent(typeof(UIViewEventBaseInterface));
            if (lr != null)
            {
                lr.OnUIViewEvent(UI_Message, _t, _tl, _tb);
                return;
            }

            DispatchEventUIRecursively(_transform.parent, UI_Message, _t, _tl, _tb);
        }

        #endregion

        #endregion

        #region 当子物体调用寻找数据，会起调以下函数接口

        /// <summary>
        /// 根据物体查找 UIBaseView类，当前物体如果没有通过递归查找父物体
        /// </summary>
        /// <param name="m_trView"></param>
        /// <returns>返回查找到的 UIBaseView类</returns>
        public UIBaseView GetRootView(Transform m_trView)
        {
            Debug.Log("需要查找物体-->" + (m_trView != null));
            var baseView = m_trView.GetComponentUtil<UIBaseView>();
            if (baseView != null)
            {
                m_UIBaseView = baseView;
            }

            if (m_trView.parent == null)
            {
                return m_UIBaseView;
            }
            else
            {
                return GetRootView(m_trView.parent);
            }
        }

        /// <summary>
        /// 根据物体查找 UIBaseView类，当前物体如果没有通过递归查找父物体
        /// </summary>
        /// <returns>返回查找到的 UIBaseView类</returns>
        public UIBaseView GetRootView()
        {
            //当前uibaseView字段 no Null 返回
            if (m_UIBaseView != null)
            {
                return m_UIBaseView;
            }
            else
            {
                // m_UIBaseView Is NULL 递归查找当前物体所有父物体是否有UIBaseView类
                return GetRootView(transform.parent);
            }
        }

        public T ApplyRootView<T>(T defaultvalue, Func<UIBaseView, T> _baseFunc)
        {
            //找出当前调用方法的UIBaseView类
            var rootBaseView = GetRootView();
            if (rootBaseView == null || rootBaseView == this)
            {
                return defaultvalue;
            }

            //调用
            return _baseFunc(rootBaseView);
        }

        public BasePageView GetBasePageView()
        {
            return GetBasePageView(transform);
        }

        public void SetRootView(UIBaseView _base)
        {
            m_UIBaseView = _base;
        }

        public BasePageView GetBasePageView(Transform m_trView)
        {
            Debug.Log("transform is Null-->" + (m_trView != null));
            var temp_TransformView = m_trView.GetComponentUtil<BasePageView>();
            if (temp_TransformView != null)
            {
                return temp_TransformView;
            }

            return GetBasePageView(m_trView.parent);
        }

        protected T ApplyRootPage<T>(T defaultValue, Func<BasePageView, T> func)
        {
            var rootPage = GetRootPage();
            if (rootPage == null || rootPage == this)
            {
                return defaultValue;
            }

            return func(rootPage);
        }

        //基础面板
        protected BasePageView GetRootPage()
        {
            //get继承 到
            return GetRootView() as BasePageView;
        }

        #endregion

        protected virtual AssetDataBaseManager mAssetDataBase
        {
            get { return AssetDataBaseManager.I; }
        }
        //创建物体
        protected void LoadPageInstantiateAssetAsync<T>(string filename, Action<T> callback)
            where T : UnityEngine.Object
        {
            mAssetDataBase.LoadInstantiateAsync<T>(filename, asset =>
            {
                Observable.FromCoroutine(UnloadUnusedAssetsWait, publishEveryYield: false)
                    .ObserveOnMainThread()
                    .Subscribe(ret => { callback.Execute(asset); })
                    .AddTo(gameObject);
            });
        }

        private IEnumerator UnloadUnusedAssetsWait()
        {
            yield return null;
        }
    }
}