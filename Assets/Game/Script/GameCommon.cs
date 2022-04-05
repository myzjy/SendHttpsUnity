// using Assets.Script.Tools;
// using MaoguoDll;
// using System;
// using UnityEngine;
// using UnityEngine.UI;
// // using XLua;
//
// // [LuaCallCSharp]
// public class GameCommon : SingleMaoGuo<GameCommon>
// {
//     //游戏主体定义lua虚拟机
//     // public LuaEnv luavm;
//     public ReadValue readValue;
//     public Text text_UI;
//
//     // LuaTable gameCommonTable;
//     Action upData;
//     protected override void OnAwake()
//     {
//         base.OnAwake();
//         // luavm = new LuaEnv();
//         // luavm.AddLoader(UnityGamesTools.MyCustomLoader);
//         SaveData();
//     }
//
//     public void SaveData()
//     {
//         readValue = new ReadValue();
//
//     }
//     //游戏循环启动 运行是在读取lua脚本之前
//     public void Update()
//     {
//         //由于Addressables 读取资源回调速度在生命周期函数之后运行所有有可能会报错
//         try
//         {
//             //upData();
//         }
//         catch (Exception)
//         {
//
//
//         }
//     }
//     protected override void OnDestroy()
//     {
//         //base.OnDestroy();
//         //gameCommonTable.Dispose();
//         // luavm.Dispose();
//
//     }
// }
//
