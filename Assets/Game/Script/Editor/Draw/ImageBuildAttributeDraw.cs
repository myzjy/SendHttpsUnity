// #if UNITY_EDITOR
// using UnityEditor;
// #endif
//
// using System;
// using UnityEngine;
//
// namespace Game.UI.Draw
// {
//     using Attribute.BuildAttribute;
//
//     [CustomEditor(typeof(BuildBaseUIData), true)]
//     public class ImageBuildAttributeDraw : Editor
//     {
//         public override void OnInspectorGUI()
//         {
//             base.OnInspectorGUI();
//             EditorGUI.indentLevel = 0;
//
//             BuildBaseUIData _buildBase = target as BuildBaseUIData;
//             
//             
//         }
//     }
// }