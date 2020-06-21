using System;
using UnityEngine.AddressableAssets;

[Serializable]
public class AssetReferenceSceneAsset : AssetReferenceT<
#if UNITY_EDITOR
    UnityEditor.SceneAsset
#else
    UnityEngine.Object
#endif
>
{
    public AssetReferenceSceneAsset(string guid) : base(guid)
    {
    }
}