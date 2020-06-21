using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class AddressablesSceneLoader : MonoBehaviour
{
    [SerializeField] private AssetReferenceSceneAsset _sceneReference;

    public void LoadSingle()
    {
        Addressables.LoadSceneAsync(_sceneReference, LoadSceneMode.Single);
    }

    public void LoadAdditive()
    {
        Addressables.LoadSceneAsync(_sceneReference, LoadSceneMode.Additive);
    }
}