using System;
using System.Collections;
using GameScene;
using UnityEngine;

namespace GameSystem.ServiceDataPro
{
    public class GameRootService
    {
        private GameRootServicePro m_gameroot = null;

        public static GameRootService CreateRoot()
        {
            var res = new GameRootService();
            return res;
        }

        private GameRootService()
        {
            m_gameroot = new GameRootServicePro();
            CreateSceneControlManager();
        }

        public GameRootServicePro ServicePro => m_gameroot;

        private SceneContorlManager _contorlManager = null;

        public SceneContorlManager SceneContorlManager => _contorlManager;
        public IEnumerator LoadAssetMaster()
        {
            yield return LoadFullMaster();
        }
        private IEnumerator LoadFullMaster()
        {
            bool isLoad = false;
            // var save = new SaveDataManage();
            // yield return save.GetDataJsonLoacel();
            m_gameroot.LoadFullMaster(() => isLoad = true);
            yield return new WaitUntil(() => isLoad);
        }

        /// <summary>
        /// 创建场景控制管理
        /// </summary>
        private void CreateSceneControlManager()
        {
            Debug.Log("创建出SceneContorl");
            var sceneObj = new GameObject("SceneContorlManager");
            UnityEngine.Object.DontDestroyOnLoad(sceneObj);
            sceneObj.AddComponent<SceneContorlManager>();
            _contorlManager = sceneObj.GetComponent<SceneContorlManager>();
        }
    }
}