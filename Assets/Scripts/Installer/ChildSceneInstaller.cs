using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ChildSceneInstaller : MonoInstaller<ChildSceneInstaller>
{
    [SerializeField] private Text _text;

    public override void InstallBindings()
    {
        Container.Bind<string>().WithId("Child").FromInstance("Binding in Child");
    }

    public override void Start()
    {
        Application.logMessageReceived += this.HandleLog;
    }

    private void OnDestroy()
    {
        Application.logMessageReceived -= this.HandleLog;
    }

    private void HandleLog(string logString, string stackTrace, LogType type)
    {
        var text = logString;

        switch (type)
        {
            case LogType.Log:
                break;
            case LogType.Warning:
                text = "<color='yellow'>" + text + "</color>";
                break;
            case LogType.Error:
            case LogType.Assert:
            case LogType.Exception:
                text = "<color='red'>" + text + "</color>";
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }

        _text.text += text + "\n";
    }
}