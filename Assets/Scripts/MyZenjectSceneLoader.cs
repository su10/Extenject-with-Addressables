using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class MyZenjectSceneLoader : MonoBehaviour
{
    [SerializeField] private AssetReferenceSceneAsset _sceneReference;

    [Inject] private ZenjectSceneLoader _sceneLoader;

    public void LoadSingle()
    {
        _sceneLoader.LoadSceneAsync(_sceneReference, LoadSceneMode.Single);
    }

    public void LoadAdditive()
    {
        _sceneLoader.LoadSceneAsync(_sceneReference, LoadSceneMode.Additive);
    }

    public void LoadAdditiveChild()
    {
        _sceneLoader.LoadSceneAsync(_sceneReference, LoadSceneMode.Additive, null, LoadSceneRelationship.Child);
    }
}