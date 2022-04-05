using UnityEngine;
public class LuaCreateAssetLoadScriptableObject:ScriptableObject
{
	[SerializeField] private TextAsset _GameCommonLua;
	public TextAsset _GetGameCommonLua
	{
		get=>_GameCommonLua;
		set=>_GameCommonLua = value;
	}

	[SerializeField] private TextAsset _UILuaBase;
	public TextAsset _GetUILuaBase
	{
		get=>_UILuaBase;
		set=>_UILuaBase = value;
	}

}

