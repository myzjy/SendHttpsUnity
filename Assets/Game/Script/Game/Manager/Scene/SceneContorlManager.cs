using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

namespace GameScene
{
    /// <summary>
    /// 场景控制管理
    /// </summary>
    public class SceneContorlManager : MonoBehaviour, SceneBaseInterface
    {
        //单例
        public static SceneContorlManager Instance;
        private bool m_isLoading = false;

        public bool IsLoading
        {
            get { return m_isLoading; }
        }

        public void Awake()
        {
            OnInit();
            OnAwake();
        }

        public void OnInit()
        {
        }

        public void OnAwake()
        {
            Instance = this;
        }

        public void OnSatart()
        {
        }

        public void OnShow()
        {
        }

        public void OnIDestroy()
        {
        }

        private GameObject CreateChildObject(string assetName)
        {
            // var obj=AssetDataBaseManager.I.LoadAsync()
            return null;
        }

        /// <summary>
        /// 跳转场景
        /// </summary>
        /// <param name="nextSceneName"></param>
        public void ChangeScene(string nextSceneName, string beforSceneName)
        {
            ChangeSceneCore(nextSceneName, beforSceneName);
        }

        private void ChangeSceneCore(string nextSceneName, string beforSceneName)
        {
            // SceneManager.CreateScene(nextSceneName);
            StartCoroutine(LoadNextScene(nextSceneName, beforSceneName));
        }

        private IEnumerator LoadNextScene(string Next, string beforSceneName)
        {
            yield return SceneManager.LoadSceneAsync(Next, LoadSceneMode.Single);
            var nowScene = SceneManager.GetSceneByName(Next);

            yield return UnloadScene(beforSceneName);
        }

        private IEnumerator UnloadScene(string beforeSceneName)
        {
            // yield return SceneManager.UnloadSceneAsync(beforeSceneName);
            yield return UnloadUnusedAssets();
        }

        private IEnumerator UnloadUnusedAssets()
        {
            yield return Resources.UnloadUnusedAssets();
            System.GC.Collect();
        }
    }
}