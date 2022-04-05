using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadHistory
{
    Dictionary<string, List<AsyncOperationHandle>> aohMap = new Dictionary<string, List<AsyncOperationHandle>>();

    public void Add(string name, AsyncOperationHandle aoh)
    {
        aohMap.TryGetValue(name, out var list);
        if (list == null) list = new List<AsyncOperationHandle>();
        list.Add(aoh);
        aohMap[name] = list;
        //Debug.LogWarning("Add:" + name);
    }

    public bool Contains(string name)
    {
        return aohMap.ContainsKey(name);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="monoString"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T GetKeyAsyncMono<T>(string monoString) where T : MonoBehaviour
    {
        var item= aohMap[monoString].First();
        return item.Result as T;
    }
    public T GetKeyAsyncClass<T>(string monoString) where T : class
    {
        var item= aohMap[monoString].First();
        return item.Result as T;
    }
    public void Release(string name)
    {
        if (aohMap.ContainsKey(name))
        {
            aohMap.TryGetValue(name, out var list);
            foreach (var item in list)
            {
                Addressables.Release(item);
            }

            aohMap.Remove(name);
            //Debug.LogWarning("Release:" + name);
        }
    }
}