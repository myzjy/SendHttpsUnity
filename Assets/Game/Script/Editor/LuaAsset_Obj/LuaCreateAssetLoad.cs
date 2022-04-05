using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class LuaCreateAssetLoad
{
    private static readonly string ASSET_LUAASSET_DATA_PATH = "Assets/GameDataScriptObj/LuaTextAsset/";

    public static void load()
    {
        var addressableAsset =
            AssetDatabase.LoadAssetAtPath<AddressableAssetString>(
                "Assets/AddressableAssetStringObj/AddressableAssetStringer.Asset");
        var assetStringPaths = addressableAsset.assetStringPathsList.Where(item => item.IsTypeName("Lua")).ToList();
        var path = assetStringPaths[0].pathList;
        AssetDatabase.LoadAllAssetsAtPath(path);

        Debug.Log("[LuaCreateAssetTool]---AssetToolUpData---");

        string ScriptableText
            = "using UnityEngine;\n" +
              "public class LuaCreateAssetLoadScriptableObject:ScriptableObject\n{\n";
        if (ScriptableText == null) throw new ArgumentNullException(nameof(ScriptableText));

        Debug.Log($"{path}");
        string fullpath = $"{path}/";
        var fullPath = new List<TextAsset>();
        if (Directory.Exists(fullpath))
        {
            DirectoryInfo _directory = new DirectoryInfo(fullpath);
            FileInfo[] _fileInfos = _directory.GetFiles("*.lua", SearchOption.AllDirectories);
            fullPath = _fileInfos.Select(a =>
            {
                string tip = a.FullName;
                tip = tip.Replace("\\", "/");
                int index = tip.IndexOf(fullpath, StringComparison.Ordinal);

                string tipsRemove = tip.Remove(0, index);
                return tipsRemove;
            }).Select(AssetDatabase.LoadAssetAtPath<TextAsset>).ToList();
            string pathStr = "";

            foreach (var item in fullPath)
            {
                pathStr += $"\t[SerializeField] private TextAsset _{item.name};\n";
                pathStr += $"\tpublic TextAsset _Get{item.name}\n";
                pathStr += "\t{\n";
                pathStr += $"\t\tget=>_{item.name};\n";
                pathStr += $"\t\tset=>_{item.name} = value;\n";
                pathStr += "\t}\n\n";
            }

            ScriptableText += pathStr;
            ScriptableText += "}\n";
        }

        Debug.Log("[LuaCreateAssetTool]---AssetToolUpDataScript Tool---");
        Debug.Log("[LuaCreateAssetTool]---AssetToolUpDataScript 开始创建---");
        var fi = new FileInfo(Application.dataPath + "/Script/Common/LuaCreateAssetLoadScriptableObject.cs");
        var sw = fi.CreateText();
        sw.WriteLine(ScriptableText);
        sw.Flush();
        sw.Close();
        Debug.Log("[LuaCreateAssetTool]---AssetToolUpDataScript 停止创建---");
        Debug.Log($"[LuaCreateAssetTool]---AssetToolUpDataScript 文件{ScriptableText}---");
        Debug.Log("[LuaCreateAssetTool]---AssetToolUpDataAsset 开始创建---");
        string script = ASSET_LUAASSET_DATA_PATH
                                             + "LuaCreateAssetLoadScriptableObject.asset";
        var data = AssetDatabase.LoadAssetAtPath<LuaCreateAssetLoadScriptableObject>(script);
        Debug.Log($"{script}");

        if (data == null)
        {
            //没有读取到对应的资源
            Debug.Log("未读取到对应资源");
            //创建
            Debug.Log("开始创建");
            data = ScriptableObject.CreateInstance<LuaCreateAssetLoadScriptableObject>();

            var type = data.GetType();
            foreach (var it in fullPath)
            {
                var info = type.GetProperty($"_Get{it.name}",
                    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (!(info is null)) info.SetValue(data, it);
            }

            data.hideFlags = HideFlags.NotEditable;
            AssetDatabase.CreateAsset((ScriptableObject) data, script);
            Debug.Log("[MessageDataTool] NewFile " + script);
        }
        else
        {
            data.hideFlags = HideFlags.NotEditable;
            var type = data.GetType();
            foreach (var it in fullPath)
            {
                var info = type.GetProperty($"_Get{it.name}",
                    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (!(info is null)) info.SetValue(data, it);
            }

            EditorUtility.SetDirty(data);
            AssetDatabase.SaveAssets();
        }

        AssetDatabase.Refresh();
    }
    
    
}