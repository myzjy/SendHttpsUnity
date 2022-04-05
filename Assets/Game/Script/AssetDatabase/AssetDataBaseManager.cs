using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assets.Script.Tools;
using Packages.Rider.Editor.Util;
using Tools.Util;
using UniRx;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Object = System.Object;

/// <summary>
/// AssetDataBase加载管理类，除AddressableAsse里面的，一切用这个类里面调用
/// </summary>
public class AssetDataBaseManager:SingleMaoGuo<AssetDataBaseManager>
{
    public void SetAsset()
    {
        InstantiateDict = new Dictionary<string, object>();
        m_spritedict = new Dictionary<string, Sprite>();
    }

    protected override void OnAwake()
    {
        base.OnAwake();
        DontDestroyOnLoad(this);
    }

    #region 加载历史

    public readonly LoadHistory loadHistory = new LoadHistory();

    #endregion
    


    private Dictionary<string, Object> InstantiateDict = null;
    private Dictionary<string, Sprite> m_spritedict = null;

    //判断是否物体有
    private bool HashAssetInstantiateGameObjectDict(string assetName) => InstantiateDict.ContainsKey(assetName);


    #region 读取资源

    public void LoadObservbleRes<T>(string name, Action<T> complate) where T : UnityEngine.Object
    {
        Observable
            .FromCoroutine<T>(ob => InstantiateAsync<T>(name, ob.OnNext))
            .ObserveOnMainThread()
            .Subscribe(res =>
            {
                UnityEngine.Debug.Log($"Not found : {name}  <{typeof(T)}>");
                complate.Execute(res);
            }).AddTo(this.gameObject);
    }

    /// <summary>
    /// 没返回类型
    /// </summary>
    /// <param name="name"></param>
    /// <param name="complate"></param>
    /// <typeparam name="T"></typeparam>
    public void LoadAsync<T>(string name, Action<T> complate)
    {
        Addressables.LoadAssetAsync<T>(name).Completed += (item) =>
        {
            UnityEngine.Debug.Log("加载完成");
            UnityEngine.Debug.Log($"加载完成{item.Result}");

            if (item.Status == AsyncOperationStatus.Succeeded)
            {
                loadHistory.Add(name, item);
                UnityEngine.Debug.Log($"加载完成{item.Result}");
                Addressables.Release(item);
                complate(item.Result);
            }
        };
    }

    #endregion


    #region 读取创建物体

    public void LoadInstantiateAsync<T>(string name, Action<T> complat) where T : UnityEngine.Object
    {
        Observable
            .FromCoroutine<T>(ob => InstantiateAsync<T>(name, ob.OnNext))
            .ObserveOnMainThread()
            .Subscribe(res =>
            {
                UnityEngine.Debug.Log($"Not found : {name}  <{typeof(T)}>");
                complat.Execute(res);
            }).AddTo(this.gameObject);
    }

    private IEnumerator InstantiateAsync<T>(string name, Action<T> complate) where T : UnityEngine.Object
    {
        bool isLoad = false;
        yield return GetUnpackInAssetData<T>(name, load => isLoad = load, complate);
        yield return new UnityEngine.WaitUntil(() => isLoad);
    }

    //读取创建预制体
    private IEnumerator GetUnpackInAssetData<T>(string objName, Action<bool> onFinish, Action<T> complate)
        where T : UnityEngine.Object
    {
        yield return GetInstantiateAssetDataImple<T>(objName, onFinish, complate);
    }

    private IEnumerator GetInstantiateAssetDataImple<T>(string objName, Action<bool> onFinish, Action<T> onComplte)
        where T : UnityEngine.Object
    {
        if (!HashAssetInstantiateGameObjectDict(objName))
        {
            UnityEngine.Debug.Log($"Not yet unpacked : {objName}");
#if !INST_RESOUCE
            onComplte.Execute<T>(null);
#else
            yield return GetInstantiateGameObject<T>(objName, onFinish);
            onComplte.Execute<T>(InstantiateDict[objName] as T);
#endif
            yield break;
        }

        if (typeof(T) != typeof(UnityEngine.Sprite))
        {
            onComplte.Execute(InstantiateDict[objName] as T);
        }

        //此时在读取时是没创建的到
        var obj = InstantiateDict[objName];
        //创建出来
        Util.InstantiateGameObject((UnityEngine.GameObject) obj);
        onComplte.Execute(obj as T);
        yield return null;
    }
#if INST_RESOUCE
    //生成物体 读取创建出来
    private IEnumerator GetInstantiateGameObject<T>(string pathName, Action<bool> onFinish)
        where T : UnityEngine.Object
    {
        bool isLoad = false;
        T _itemObj = default(T);
        //循环判断是否读取成功
        UnityEngine.Debug.Log("开始加载");
        Addressables.InstantiateAsync(pathName).Completed += (item) =>
        {
            UnityEngine.Debug.Log("加载完成");
            if (item.Status == AsyncOperationStatus.Succeeded)
            {
                if (item.Result == null)
                {
                    _itemObj = default(T);
                    AddInstantiateObjDict(pathName, _itemObj);
                    UnityEngine.Debug.Log($"{GetContainsUpparCaseErrorString(pathName)}");
                    isLoad = true;
                }
                else
                {
                    loadHistory.Add(pathName, item);
                    UnityEngine.Debug.Log($"加载完成{item.Result}");
                    _itemObj = item.Result as T;
                    UnityEngine.Debug.Log($"加载完成 GetComponent{_itemObj}  TYPE{typeof(T)}");
                    AddInstantiateObjDict(pathName, _itemObj);
                    isLoad = true;
                }
            }
        };
        yield return new UnityEngine.WaitUntil(() => isLoad);
        onFinish(isLoad);
    }
#endif
    string GetContainsUpparCaseErrorString(string str)
    {
        return $"{str} contains Uppercase";
    }

    private void AddInstantiateObjDict(string pathName, object _ASSET)
    {
        if (HashAssetInstantiateGameObjectDict(pathName))
        {
            InstantiateDict[pathName] = _ASSET;
        }
        else
        {
            InstantiateDict.Add(pathName, _ASSET);
        }
    }

    #endregion


    public void LoadAsyncTextAsset(string name, Action<UnityEngine.TextAsset> complate)
    {
        Addressables.LoadAssetAsync<UnityEngine.TextAsset>(name).Completed += (item) =>
        {
            UnityEngine.Debug.Log("加载完成");

            loadHistory.Add(name, item);
            UnityEngine.Debug.Log($"加载完成{item.Result.text}");

            var text = item.Result;
            Addressables.Release(item);

            complate(item.Result);
        };
    }

    private string assetBasePath = "Assets/AddressableAssetStringObj/AddressableAssetStringer.Asset";

    public void InstantiateSprite(string sprite_name, Action<UnityEngine.Sprite> complate)
    {
        UnityEngine.Object scriptable = null;
        LoadInstantiateAsync<UnityEngine.Object>("AddressableAssetStringer", (obj) => { scriptable = obj; });
        var addressableAsset = scriptable as AddressableAssetString;
        var list = addressableAsset.assetStringPathsList.Where(a => a.uiName == "SpriteAtlas").ToList();
        for (int i = 0; i < list.Count; i++)
        {
            string fullpath = string.Format("{0}/", list[i].pathList);
            if (Directory.Exists(fullpath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(fullpath);
                FileInfo[] fileInfos = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
                string[] fullPath = fileInfos.Where(a => !(a.Name.EndsWith(".meta"))).Select(a =>
                {
                    string tip = a.FullName;
                    tip = tip.Replace("\\", "/");
                    int index = tip.IndexOf(fullpath);
                    int nameIndex = tip.IndexOf(list[i].name.name) + list[i].name.name.Length + 1;
                    string tipsRemove1 = tip.Remove(0, nameIndex);
                    tipsRemove1 = tipsRemove1.Substring(0, tipsRemove1.IndexOf("."));

                    return tipsRemove1;
                }).ToArray();

                for (int k = 0; k < fullPath.Length; k++)
                {
                    if (InstantiateSpriteAtlas(fullPath[i], sprite_name, complate))
                    {
                        return;
                    }
                }
            }
        }
    }

    #region 读取图集内部sprite 先读取所有图集

    private Func<UniRx.IObserver<Unit>, IEnumerator>[] m_loadIeFunc;

    private void SetUpLoadBaseDataIe()
    {
        // ReSharper disable once RedundantCheckBeforeAssignment
        if (m_loadIeFunc != null) m_loadIeFunc = null;
        var list = new List<Func<UniRx.IObserver<Unit>, IEnumerator>>()
        {
            LoadIESpriteAtlas
        };
        m_loadIeFunc = list.ToArray();
    }

    private UniRx.IObservable<Unit> SelectCoroutine(Func<UniRx.IObserver<Unit>, IEnumerator> cororoutine) =>
        Observable.FromCoroutine(cororoutine);

    public IEnumerator LoadAllSpriteAtla()
    {
        bool isLoad = false;
        LoadAllspriteUniRX().ObserveOnMainThread().Subscribe(res => { isLoad = true; }).AddTo(gameObject);
        yield return new WaitUntil(() => isLoad);
    }

    private UniRx.IObservable<Unit> LoadAllspriteUniRX()
    {
        SetUpLoadBaseDataIe();
        //选择出我可以执行的 读取资源携程
        return m_loadIeFunc.Select(SelectCoroutine).WhenAll();
    }

    private IEnumerator LoadIESpriteAtlas(UniRx.IObserver<Unit> observer)
    {
        yield return LoadIESpriteAtlas(observer, "Item");
    }

    private IEnumerator LoadIESpriteAtlas(UniRx.IObserver<Unit> observer, string spriteAtlas)
    {
        Debug.Log($"启动查找{spriteAtlas}图集");
        bool isLoad = false;
        Observable.FromCoroutine<UnityEngine.U2D.SpriteAtlas>(ob =>
                LoadSpriteAssetsWait<UnityEngine.U2D.SpriteAtlas>(spriteAtlas, ob.OnNext, isLoa => isLoad = isLoa))
            .ObserveOnMainThread()
            .Subscribe(LoadSprite)
            .AddTo(gameObject);
        yield return new WaitUntil(() => isLoad);
        Finish(observer, "");
    }

    private IEnumerator LoadSpriteAssetsWait<T>(string sprite, Action<T> onCmplte, Action<bool> isLoadOn)
        where T : UnityEngine.U2D.SpriteAtlas
    {
        bool isLoad = false;
        // Addressables.ResourceLocators
        Addressables.LoadAssetAsync<UnityEngine.U2D.SpriteAtlas>(sprite).Completed += (item) =>
        {
            loadHistory.Add(sprite, item);
            onCmplte.Execute(item.Result as T);
            isLoad = true;
            isLoadOn.Execute(isLoad);
        };
        yield return new UnityEngine.WaitUntil(() => isLoad);
    }

    private void LoadSprite(UnityEngine.U2D.SpriteAtlas _sprite)
    {
        Debug.Log($"查找{_sprite.name}图集 成功 解析内部图集 抽取图片并保存");

        var sprite = _sprite.GetPackables();
        var list = sprite.Select(a =>
            {
                var item = _sprite.GetSprite(a.name);
                item.name = a.name;
                return item;
            }
        ).ToList();
        list.ToList().ForEach(a => { Debug.Log(a); });
    }

    /// <summary>
    /// 启动对应响应事件
    /// </summary>
    /// <param name="observer">响应的事件</param>
    /// <param name="error">是否有错误消息</param>
    private void Finish(UniRx.IObserver<Unit> observer, string error)
    {
        if (!string.IsNullOrEmpty(error))
        {
            //弹出报错消息
            observer.OnError(new Exception(error));
        }
        else
        {
            //转换执行接下来事件
            observer.OnNext(Unit.Default);
        }

        //正式启动 响应事件 
        observer.OnCompleted();
    }

    #endregion

    private bool InstantiateSpriteAtlas(string atlas_name, string sprite_name, Action<UnityEngine.Sprite> complate)
    {
        bool isLoad = false;
        try
        {
            Addressables.LoadAssetAsync<UnityEngine.U2D.SpriteAtlas>(atlas_name).Completed += (item) =>
            {
                loadHistory.Add(atlas_name, item);
                Sprite sprite = item.Result.GetSprite(sprite_name);
                isLoad = true;
                complate(sprite);
            };
        }
        catch (Exception)
        {
            isLoad = false;
        }

        return isLoad;
    }
}