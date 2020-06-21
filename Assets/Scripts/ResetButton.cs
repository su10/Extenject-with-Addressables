using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
#if UNITY_EDITOR
    private static readonly MethodInfo ClearMethod =
        typeof(AssetDatabase)
            .Assembly
            .GetType("UnityEditor.LogEntries")
            .GetMethod("Clear", BindingFlags.Static | BindingFlags.Public);
#endif

    public void ResetScene()
    {
        SceneManager.LoadScene("Parent");

#if UNITY_EDITOR
        ClearMethod.Invoke(null, null);
#endif
    }
}