using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class ChangeTheFileNameSuffixEditor
{
    //[MenuItem("Tool/XLUA/lua文件后缀改为.lua.txt")]
    FileSystemWatcher fileSystem;

    //开始监听
    public void TheFileNameSuffix(string path)
    {
        if (fileSystem == null)
        {
            fileSystem = new FileSystemWatcher();
        }

        fileSystem.BeginInit();
        fileSystem.EnableRaisingEvents = true;
        fileSystem.NotifyFilter = NotifyFilters.DirectoryName | NotifyFilters.Size;
        fileSystem.Path = Application.dataPath + "Lua/";
        fileSystem.Created += new FileSystemEventHandler(OnCreated);
        fileSystem.EndInit();
    }

    private void OnCreated(object sed, FileSystemEventArgs eventArgs)
    {
        Debug.Log("1" + sed);
    }
}

public class OnAssetEvent : UnityEditor.AssetPostprocessor
{
    // public static void OnPostprocessAllAssets(string[] importedAsset, string[] deletedAssets, string[] movedAssets,
    //     string[] movedFromAssetPaths)
    // {
    //     foreach (string str in importedAsset)
    //     {
    //         if (IsLuaTxtPath(str))
    //         {
    //             LuaCreateAssetLoad.load();
    //         }
    //         //不存在需要创建
    //         Debug.Log("importedAsset = " + str);
    //     }
    //
    //     // foreach (string str in deletedAssets)
    //     // {
    //     //     Debug.Log("deletedAssets = " + str);
    //     // }
    //     //
    //     // foreach (string str in movedAssets)
    //     // {
    //     //     Debug.Log("movedAssets = " + str);
    //     // }
    //     //
    //     // foreach (string str in movedFromAssetPaths)
    //     // {
    //     //     Debug.Log("movedFromAssetPaths = " + str);
    //     // }
    // }

    private static bool IsLuaTxtPath(string path)
    {
        string pathBase = "Assets/Lua/";
        if (path.Contains(pathBase))
        {
            return true;
        }
        return false;
    }

    private static bool IsAudioBGMPath(string path)
    {
        string pathBaes = "Assets/GameDataScriptObj/Audio/AudioClip/";
        if (path.Contains(pathBaes))
        {
            return true;
        }
        return false;
    }
    //public static void Import()
    //{
    //        LoadSetting();
    //        string path = EditorUtility.OpenFilePanel("请选择CSV文件", "./", "csv");
    //        if (path.Length == 0)
    //        {
    //                return;
    //        }

    //        try
    //        {
    //                using (var sr = new System.IO.StreamReader(path))
    //                {
    //                        Debug.Log("[MessageDataTool]---MessageData Import---");

    //                        string enumText =
    //                                "namespace Dpuzzle {\n" +
    //                                "public enum Message {\n";

    //                        int languageCount = 0;
    //                        List<string>[] messageLists = null;

    //                        // 1行目から言語数を取得
    //                        if (!sr.EndOfStream)
    //                        {
    //                                var line = sr.ReadLine();
    //                                var values = line.Split(',');
    //                                languageCount = values.Length - 2;

    //                                messageLists = new List<string>[languageCount];
    //                                for (int i = 0; i < languageCount; ++i)
    //                                {
    //                                        messageLists[i] = new List<string>();
    //                                }
    //                        }

    //                        // データがなくなるまでループ
    //                        while (!sr.EndOfStream)
    //                        {
    //                                var line = sr.ReadLine();
    //                                var values = line.Split(',');

    //                                string key = values[1];

    //                                if (string.IsNullOrEmpty(key))
    //                                {
    //                                        continue;
    //                                }

    //                                if (values.Length > 2)
    //                                {
    //                                        string comment = values[2];
    //                                        if (!string.IsNullOrEmpty(comment))
    //                                        {
    //                                                enumText += string.Format("/// <summary>\n/// {0}\n/// </summary>\n", comment);
    //                                                //enumText += string.Format("/// {0}\n", comment);
    //                                        }
    //                                }

    //                                enumText += key + ",\n";

    //                                for (int i = 0; i < languageCount; ++i)
    //                                {
    //                                        string value = values[2 + i];
    //                                        value = ReplaceTag(value);
    //                                        messageLists[i].Add(value);
    //                                }
    //                        }
    //                        enumText += "MAX_NUM\n}\n}";

    //                        // EnumMessage.cs作成
    //                        StreamWriter sw;
    //                        FileInfo fi;
    //                        fi = new FileInfo(Application.dataPath + setting.enumFilePath + "EnumMessage.cs");
    //                        sw = fi.CreateText();
    //                        sw.WriteLine(enumText);
    //                        sw.Flush();
    //                        sw.Close();

    //                        // ScriptableObject作成
    //                        for (int i = 0; i < languageCount; ++i)
    //                        {
    //                                string scriptablePath = setting.outputDataPath + MESSAGE_DATA_PREFIX + messageLists[i][0] + ".asset";

    //                                var data = AssetDatabase.LoadAssetAtPath<MessageData>(scriptablePath);
    //                                if (data != null)
    //                                {
    //                                        // 有的话更新
    //                                        data.hideFlags = HideFlags.NotEditable;
    //                                        data.messages = messageLists[i].ToArray();

    //                                        EditorUtility.SetDirty(data);
    //                                        AssetDatabase.SaveAssets();
    //                                }
    //                                else
    //                                {
    //                                        // 没有的话就做
    //                                        data = ScriptableObject.CreateInstance<MessageData>();

    //                                        data.hideFlags = HideFlags.NotEditable;
    //                                        data.messages = messageLists[i].ToArray();

    //                                        AssetDatabase.CreateAsset((ScriptableObject)data, scriptablePath);

    //                                        Debug.Log("[MessageDataTool] NewFile " + MESSAGE_DATA_PREFIX + messageLists[i][0] + ".asset");
    //                                }
    //                        }

    //                        Debug.Log("[MessageDataTool]---MessageData Updated!---");
    //                        AssetDatabase.Refresh();
    //                }
    //        }
    //        catch (System.Exception e)
    //        {
    //                Debug.LogError(e.Message);
    //        }
    //}

    //public static string ReplaceTag(string value)
    //{
    //        value = value.Replace(NEWLINE_REPLACE_TAG_BR, "\n");
    //        value = value.Replace(NEWLINE_REPLACE_TAG_N, "\n");
    //        value = value.Replace("⚠️", "⚠");
    //        return value;
    //}
}