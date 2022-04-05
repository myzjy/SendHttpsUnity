using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 读取生成LuaAsset资源
/// </summary>
public static class LuaAssetLoadScriptImpteEditor
{
    private static readonly string ASSET_LUAASSET_DATA_PATH = "Assets/GameDataScriptObj/LuaCreateAsset/";
    private static readonly string luaSetAsset = "LuaAssetScriptImpte";

    [MenuItem("Tool/Addressable/BuildAssertLua")]
    public static void Import()
    {
        string script = ASSET_LUAASSET_DATA_PATH + luaSetAsset + ".asset";
        Debug.Log($"{script}");

        var data = AssetDatabase.LoadAssetAtPath<LuaAssetScriptImpteEditor>(script);
        Debug.Log(data);
        if (data == null)
        {
            //没有读取到对应的资源
            Debug.Log("未读取到对应资源");
            //创建
            Debug.Log("开始创建");
            data = ScriptableObject.CreateInstance<LuaAssetScriptImpteEditor>();
            Debug.Log($"开始创建{data}");

            data.hideFlags = HideFlags.NotEditable;
            AssetDatabase.CreateAsset((ScriptableObject) data, script);
            Debug.Log(
                $"<color=#ff0000>[LuaScriptDataTool] NewFile{ASSET_LUAASSET_DATA_PATH + luaSetAsset}.asset</color>");
        }
        else
        {
            data.hideFlags = HideFlags.NotEditable;
            Debug.Log("读取到对应资源");

          

        }
    }
}