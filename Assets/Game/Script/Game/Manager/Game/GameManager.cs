using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Script.Tools;
using Game.GameManager;
using Game.Manager.Message;
using GameData.Net;
using GameScene;
using GameSystem.ServiceDataPro;
using GameSystem.ServiceDataStruct;
using Tools.Util;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using ZJY.NetData;
using Object = System.Object;

public class GameManager : SceneBase
{

    protected override void Awake()
    {
        base.Awake();
    }
    // Start is called before the first frame update

    protected override IEnumerator Prepare()
    {
        yield return base.Prepare();
        var login = GetServiceData<UserService>().LogInfoSBD;
        //采集猫薄荷
        GetServiceData<CatnipCollectionDataPro>().SetCatnipColloection(login.CollectionVo);

        //采集猫薄荷
        GetServiceData<CatnipLocalDataPro>().SetCatnipColloection(login.CollectionVo);

        yield return StartScene();
    }


    private void AddEventHandlers()
    {
   
    }

    private BuildManager m_buildmanager = null;

    public Transform m_canvasTransform = null;

    private MessageManager m_messagedata = null;


    /// <summary>
    /// startScene
    /// </summary>
    /// <returns></returns>
    private IEnumerator StartScene()
    {
        var Message = new GameObject("MessageMagaer");
        Message.AddComponent<MessageManager>();
        m_messagedata = Message.GetComponent<MessageManager>();
        bool isLoad = false;
        MessageData _message = null;
        mAssetDataBase.LoadAsync<object>("Message", (a) =>
        {
            Debug.Log($"Messagedata加载成功");
            _message = a as MessageData;
            m_messagedata.SetMessageData(_message);
        });
        //文本资源是否读取完毕
        yield return new WaitUntil(() => (_message));
        //读取图集 所有图集读取完毕
        yield return mAssetDataBase.LoadAllSpriteAtla();
        //开始生成场景
        var buildObjManager = new GameObject("BuildManager")
        {
            transform =
            {
                parent = this.transform,
                localPosition = Vector3.zero
            }
        };
        //添加建筑管理
        buildObjManager.AddComponent<BuildManager>();
        m_buildmanager = buildObjManager.GetComponent<BuildManager>();
        isLoad = false;
        GameObject buildBase = null;
        //生成CanvasBase
        LoadPageInstantiateAssetAsync<GameObject>("CanvasBase", obj =>
        {
            buildBase = obj;
            isLoad = true;
        });
        //CanvasBase Load完毕
        yield return new WaitUntil(() => isLoad);
        buildBase.transform.parent = buildObjManager.transform;

        buildBase.transform.localPosition = Vector3.zero;
        //将我创建出来canvas存储
        m_buildmanager.SetCanvas(buildBase.GetComponent<Canvas>());
    }

    //点击采集猫薄荷事件
    // /// <summary>
    // /// 点击采集猫薄荷
    // /// </summary>
    // /// <param name="_catAbstract"></param>
    // /// <param name="_collection"></param>
    // private void RefureCatnipCollection(BuildBaseObj[] _catAbstract)
    // {
    //     GetServiceData<CatnipCollectionDataPro>().RequestCatnipJson(res =>
    //     {
    //         GetServiceData<UserService>().CreateCatnipLocalData(res, item =>
    //         {
    //             GetServiceData<CatnipLocalDataPro>().SetCatnipLocalData(item);
    //             foreach (var catAbstract in _catAbstract)
    //             {
    //                 //刷新建筑内部数据
    //                 catAbstract.ClickSell();
    //             }
    //         });
    //     });
    // }
    
    // private void RefureCatnipLoalItem(BuildBaseObj[] _catAbstract)
    // {
    //     //点击采集猫薄荷 传递 我需要更新是的建筑
    //     DispatchUIViewEvent("CatnipCollectionData", _catAbstract);
    // }
    
}