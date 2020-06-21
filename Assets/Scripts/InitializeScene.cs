using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializeScene : MonoBehaviour
{
    IEnumerator Start()
    {
        DontDestroyOnLoad(this.gameObject);

        yield return null;

        while (1 < SceneManager.sceneCount)
        {
            SceneManager.UnloadScene(SceneManager.sceneCount - 1);
        }

        SceneManager.LoadScene("Parent");
    }
}