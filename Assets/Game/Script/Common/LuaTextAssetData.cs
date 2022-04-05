using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LuaTextAssetData : ScriptableObject
{
        [SerializeField]
        private TextAsset[] LuaTextAssets;
        public int Length => LuaTextAssets.Length;
#if UNITY_EDITOR
        public TextAsset[] GetLuaTextAssets { set => LuaTextAssets = value; }
#endif
        public TextAsset GetLuaTextAsset(int key)
        {
                return null;
        }
}
