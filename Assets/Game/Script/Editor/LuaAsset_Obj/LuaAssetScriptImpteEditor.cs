using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaAssetScriptImpteEditor : ScriptableObject
{
    //初始化生成Lua文件
    [SerializeField] private TextAsset _TextAsset;
    public TextAsset _GetText
    {
        get => _TextAsset;
        set => _TextAsset = value;
    }
}