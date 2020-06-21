using Zenject;

public class AncestorSceneInstaller : MonoInstaller<AncestorSceneInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<string>().WithId("Ancestor").FromInstance("Ancestor");
    }
}