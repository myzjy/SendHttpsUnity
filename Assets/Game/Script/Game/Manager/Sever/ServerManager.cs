// using System.Collections;
// using System.Collections.Generic;
// using MaoguoDll.NumData;
// using UnityEngine;
// using ZJY.NetData;
// using  MaoguoDll.NumData.Model;
//
// public class ServerManager
// {
//     public void StartUseTop()
//     {
//         UseTopData useTopData = new UseTopData();
//         useTopData.onSuccess = (res) =>
//         {
//             var objValueDataStrings = res.valueDataStrings;
//             Debug.unityLogger.Log(objValueDataStrings);
//
//             foreach (var it in objValueDataStrings)
//             {
//                 // Debug.unityLogger.Log(it);
//             }
//         };
//         GameDataHandler.Requset(useTopData);      
//     }
// }