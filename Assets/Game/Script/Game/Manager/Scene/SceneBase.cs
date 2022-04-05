using System;
using System.Collections;
using Game.UI.BaseView;
using Game.UI.Common;
using GameSystem.ServiceDataPro;
using Scene.Type;
using UnityEngine;
using Object = UnityEngine.Object;

namespace GameScene
{
    public class SceneBase : BasePageView
    {
        private static GameRootService gameRoot = null;

        protected virtual void Awake()
        {
            if (gameRoot == null)
            {
                gameRoot = GameRootService.CreateRoot();
            }
            SceneLoadingInit();


            StartCoroutine(Prepare());
        }

        protected override GameRootServicePro GameRoot
        {
            get { return gameRoot.ServicePro; }
        }

        /// <summary>
        /// 更改场景
        /// </summary>
        /// <param name="_sceneType"></param>
        /// <param name="_beforeScene"></param>
        protected virtual void ChangeScene(SceneType _sceneType, SceneType _beforeScene)
        {
            gameRoot.SceneContorlManager.ChangeScene(_sceneType.ToString(), _beforeScene.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nextSceneName"></param>
        public void ChangeScene(string nextSceneName)
        {
        }

        protected virtual IEnumerator Prepare()
        {
            //是否被创建出来
            if (!AssetDataBaseManager.IsNotNull())
            {
                CreateAssetDataBaseGameObject();
            }

            yield return gameRoot.LoadAssetMaster();
        }

        private void CreateAssetDataBaseGameObject()
        {
            var obj = new GameObject();
            Object.Instantiate(obj);
            var asset = obj.AddComponent<AssetDataBaseManager>();
            obj.name = "AssetDataBaseManager";
            asset.SetAsset();
        }

        protected override AssetDataBaseManager mAssetDataBase
        {
            //AssetDataBaseManager 管理类采用单例
            get { return AssetDataBaseManager.I; }
        }
    }
}