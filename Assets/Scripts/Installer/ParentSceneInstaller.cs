using UnityEngine.UI;
using Zenject;

public class ParentSceneInstaller : MonoInstaller<ParentSceneInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<string>().WithId("Parent").FromInstance("Binding in Parent");
    }

    public void DisableAllButtons()
    {
        foreach (var button in this.GetComponentsInChildren<Button>())
        {
            button.interactable = false;
        }
    }
}