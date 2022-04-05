#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;

public class SceneList
{
    [MenuItem("Tools/Start", false, 1)]
    private static void OpenStartScene()
    {
        EditorSceneManager.OpenScene($"Assets/Scenes/Start.unity");
    }
}
#endif