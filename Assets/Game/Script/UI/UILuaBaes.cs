using System.IO;
using Game.Manager.Message;
using GameData.Net;
using GameSystem.ServiceDataStruct;
using GameSystem.ServiceDataVo;
using UnityEngine;
// using XLua;

//ui基础类 所有ui都需要继承这个类
// [Hotfix]
// [LuaCallCSharp]
public class UILuaBaes : MonoBehaviour, UI_Base_Interface
{
    public Canvas _UICanvas;

    public CanvasGroup _UICanvasGroup;

    //初始化ui
    public virtual void OnInit()
    {
        Debug.Log("11");
    }

    public virtual void OnAwake()
    {
        Debug.Log("OnAwake NOT");
    }

    public virtual void OnSatart()
    {
    }

    public virtual void OnIDestroy()
    {
    }

    public virtual void OnShow()
    {
    }

    public virtual void OnClose()
    {
    }

    public void Close()
    {
    }

    public void OnOpen()
    {
    }

    //private Button back

    // LuaTable UILa;

    //只在界面打开调用
    void Awake()
    {
        // ServiceLoad _load = new ServiceLoad();
        // LoginSDVO _catnip = new LoginSDVO();
        // _load.StartServiceSaveLoadJson<LoginSDVO>(_catnip,"api/{0}/login_sever");
        // MessageManager.I.GetMessage(Message.BTN_ALL);
        // ServerManager serverManager = new ServerManager();
        // serverManager.StartUseTop();
        // AssetDataBaseManager.I.LoadAsync<object>("Message", (a) =>
        // {
        //     Debug.Log(a as MessageData);
        // });

    }
    


    void Start()
    {
        // GameCommon.I.luavm.DoString("require UILuaBase", "UILuaBase");
        OnSatart();
    }


    private void OnDestroy()
    {
        OnIDestroy();
    }
    //public bool 
}