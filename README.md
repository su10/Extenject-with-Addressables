# Extenject with Addressables
Extenjectの `ZenjectSceneLoader` でAddressablesのシーン参照を読み込めるようにしたときの挙動検証用プロジェクト

# 環境
* Unity：2018.4.21f1
* Extenject：8.0.1
* Addressables：1.10.0 

# シーンをAddressablesのシーン参照で読み込む場合の挙動
|         API         | ProjectContext Bindings | Parent Bindings | Self Bindings |
| :------------------ | :---------------------: | :-------------: | :-----------: |
| `Addressables.LoadSceneAsync(.. Single)`                           | ⭕ | - | ⭕ |
| `Addressables.LoadSceneAsync(.. Additive)`                         | ⭕ | ❌ | ⭕ |
| `Addressables.LoadSceneAsync(.. Additive)` ＋ Contract Names       | ⭕ | ⭕ | ⭕ |
| `ZenjectSceneLoader#LoadSceneAsync(.. Single)`                     | ✅ | - | ✅ |
| `ZenjectSceneLoader#LoadSceneAsync(.. Additive, .. Child)`         | ✅ | ✅ | ✅ |
| `ZenjectSceneLoader#LoadSceneAsync(.. Additive)` ＋ Contract Names | ✅ | ✅ | ✅ |

* ⭕,❌：そのままの状態のときの挙動
* ✅：APIを足したことにより実現した挙動

![Demo](https://github.com/su10/Extenject-with-Addressables/blob/master/images/Extenject_with_Addressables.gif?raw=true)

# ビルド方法
0. Window -> Asset Management -> Addressables -> Groups を開く
0. 開いたウィンドウの Build -> New Build -> Default Build Script でAssetBundleをビルド
0. [Build And Run] など通常のやり方でビルド