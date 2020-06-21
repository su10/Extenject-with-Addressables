using Zenject;

public class ProjectInstaller : MonoInstaller<ProjectInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<string>().WithId("Project").FromInstance("Binding in ProjectContext");
    }
}