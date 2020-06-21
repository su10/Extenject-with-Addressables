using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LogBindingsButton : MonoBehaviour
{
    [InjectOptional(Id = "Project")] private string _projectBinding = "null";
    [InjectOptional(Id = "Parent")] private string _parentBinding = "null";
    [InjectOptional(Id = "Child")] private string _childBinding = "null";

    public void Log()
    {
        Assert("Binding in ProjectContext", _projectBinding);

        if (SceneManager.GetSceneByName("Parent").isLoaded)
        {
            Assert("Binding in Parent", _parentBinding);
        }

        Assert("Binding in Child", _childBinding);
    }

    private void Assert(string expected, string actual)
    {
        if (expected == actual)
        {
            Debug.Log($"OK: {actual}");
        }
        else
        {
            Debug.LogError($"expected \"{expected}\" but \"{actual}\"");
        }
    }
}