using System;
using System.Collections.Generic;
using Game.UI.BaseView;
using GameSystem.ServiceDataPro;
using Tools.Util;

namespace Game.UI.Common
{
    public class BasePageView : UIBaseView, UIViewEventBaseInterface
    {
        private Dictionary<string, Action> m_viewEventsActionDict;

        private Dictionary<string, Action<object>> m_viewEventDict;
        private Dictionary<string, Action<object, object>> m_viewEventsDict;
        private Dictionary<string, Action<object, object, object>> m_viewEventActionDict;
        private Action<string> OnUIViewEventActions;

        private Action<object, string> OnUIViewEventAction;

        private Action<object, object, string> OnUIViewEventAction1;

        private Action<object, object, object, string> OnUIViewEventAction2;

        /// <summary>
        /// 场景转换Loading 转换到场景中起调初始
        /// </summary>
        protected void SceneLoadingInit()
        {
#if UNITY_EDITOR
            UnityEngine.Debug.Log("初始化事件");
#endif
            if (OnUIViewEventActions==null)
            {
                OnUIViewEventActions = (_str) =>
                {
                    if (m_viewEventDict != null && m_viewEventsActionDict.ContainsKey(_str))
                    {
                        m_viewEventsActionDict[_str].Execute();
                    }
                    else
                    {
                        DispatchUIViewEvent(_str);
                    }
                };
            }
            if (OnUIViewEventAction == null)
            {
                OnUIViewEventAction = (item, _str) =>
                {
                    if (m_viewEventDict != null && m_viewEventDict.ContainsKey(_str))
                    {
                        m_viewEventDict[_str].Execute(item);
                    }
                    else
                    {
                        DispatchUIViewEvent(_str, item);
                    }
                };
            }

            if (OnUIViewEventAction1 == null)
            {
                OnUIViewEventAction1 = (o, o1, arg3) =>
                {
                    if (m_viewEventsDict != null && m_viewEventsDict.ContainsKey(arg3))
                    {
                        m_viewEventsDict[arg3].Execute(o, o1);
                    }
                    else
                    {
                        DispatchUIViewEvent(arg3, o, o1);
                    }
                };
            }

            if (OnUIViewEventAction2 == null)
            {
                OnUIViewEventAction2 = (o, o1, arg3, arg4) =>
                {
                    if (m_viewEventActionDict != null && m_viewEventActionDict.ContainsKey(arg4))
                    {
                        m_viewEventActionDict[arg4].Execute(o, o1, arg3);
                    }
                    else
                    {
                        DispatchUIViewEvent(arg4, o, o1, arg3);
                    }
                };
            }
        }

        public void OnUIViewEvent<T>(string Message, T view_obj)
        {
            OnUIViewEventAction.Execute(view_obj, Message);
        }

        public void OnUIViewEvent<T, TL>(string Message, T view_obj, TL view_objTl)
        {
            OnUIViewEventAction1.Execute(view_obj, view_objTl, Message);
        }

        public void OnUIViewEvent<T, TL, TB>(string Message, T view_obj, TL view_objTl, TB view_objTb)
        {
            OnUIViewEventAction2.Execute(view_obj, view_objTl, view_objTb, Message);
        }

        #region Add添加事件函数 不带泛型函数
    
        private void AddOnUIViewEventHandler(string Message, Action<object> _act)
        {
            if (string.IsNullOrEmpty(Message) || _act == null)
            {
                throw new NotImplementedException("Message is not Implemented Action is Null " + GetType().FullName);
            }

            if (m_viewEventDict.IsDictNull())
            {
                m_viewEventDict = new Dictionary<string, Action<object>>()
                {
                    {
                        Message, _act
                    }
                };
            }
            else
            {
                if (m_viewEventDict.ContainsKey(Message))
                {
                    m_viewEventDict[Message] = _act;
                }
                else
                {
                    m_viewEventDict.Add(Message, _act);
                }
            }
        }

        private void AddOnUIViewEventHandler(string Message, Action<object, object> _act)
        {
            if (string.IsNullOrEmpty(Message) || _act == null)
            {
                throw new NotImplementedException("Message is not Implemented Action is Null " + GetType().FullName);
            }

            if (m_viewEventsDict.IsDictNull())
            {
                m_viewEventsDict = new Dictionary<string, Action<object, object>>()
                {
                    {
                        Message, _act
                    }
                };
            }
            else
            {
                if (m_viewEventsDict.ContainsKey(Message))
                {
                    m_viewEventsDict[Message] = _act;
                }
                else
                {
                    m_viewEventsDict.Add(Message, _act);
                }
            }
        }

        private void AddOnUIViewEventHandler(string Message, Action<object, object, object> _act)
        {
            if (string.IsNullOrEmpty(Message) || _act == null)
            {
                throw new NotImplementedException("Message is not Implemented Action is Null " + GetType().FullName);
            }

            if (m_viewEventActionDict.IsDictNull())
            {
                m_viewEventActionDict = new Dictionary<string, Action<object, object, object>>()
                {
                    {
                        Message, _act
                    }
                };
            }
            else
            {
                if (m_viewEventActionDict.ContainsKey(Message))
                {
                    m_viewEventActionDict[Message] = _act;
                }
                else
                {
                    m_viewEventActionDict.Add(Message, _act);
                }
            }
        }

        #endregion

        #region Add添加事件函数 带泛型函数 调用不带泛型函数的方法
        protected void AddOnUIViewEventHandler(string Message, Action _act)
        {
            if (string.IsNullOrEmpty(Message) || _act == null)
            {
                throw new NotImplementedException("Message is not Implemented Action is Null " + GetType().FullName);
            }

            if (m_viewEventDict.IsDictNull())
            {
                m_viewEventsActionDict = new Dictionary<string, Action>()
                {
                    {
                        Message, _act
                    }
                };
            }
            else
            {
                if (m_viewEventsActionDict.ContainsKey(Message))
                {
                    m_viewEventsActionDict[Message] = _act;
                }
                else
                {
                    m_viewEventsActionDict.Add(Message, _act);
                }
            }
        }
        protected void AddOnUIViewEventHandler<T>(string Message, Action<T> _act)
        {
            AddOnUIViewEventHandler(Message, (arg) =>
            {
                //隐式转换
                _act.Execute((T) arg);
            });
        }

        public void AddOnUIViewEventHandler<T, Tn>(string Message, Action<T, Tn> _act)
        {
            AddOnUIViewEventHandler(Message, (arg, arg2) =>
            {
                //隐式转换
                _act.Execute((T) arg, (Tn) arg2);
            });
        }

        public void AddOnUIViewEventHandler<T, Tn, Tl>(string Message, Action<T, Tn, Tl> _act)
        {
            AddOnUIViewEventHandler(Message, (arg, arg2, arg3) =>
            {
                //隐式转换
                _act.Execute((T) arg, (Tn) arg2, (Tl) arg3);
            });
        }

        #endregion

        #region Get数据协议 具体数据

        protected T GetServiceData<T>() where T : BaseServiceData, new()
        {
            return GameRoot.GetServiceDataPro<T>();
        }

        protected virtual GameRootServicePro GameRoot
        {
            get { return ApplyRootPage(null, root => root.GameRoot); }
        }

        protected new T ApplyRootPage<T>(T defaultValue, Func<BasePageView, T> func)
        {
            var rootPage = GetRootPage();
            if (rootPage == null || rootPage == this)
            {
                return defaultValue;
            }

            return func(rootPage);
        }

        //基础面板
        protected new BasePageView GetRootPage()
        {
            //get继承 到
            return GetRootView() as BasePageView;
        }

        #endregion

     
    }
}