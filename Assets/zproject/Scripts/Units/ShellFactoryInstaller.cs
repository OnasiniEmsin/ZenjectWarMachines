using Zenject;
using UnityEngine;

public class ShellFactoryInstaller : MonoInstaller
{
    public GameObject bulletPrefab;
    public Transform canvas;
    public override void InstallBindings()
    {
        Container.BindMemoryPool<Shell, Shell.Pool>()
            .WithInitialSize(20)
            .FromComponentInNewPrefab(bulletPrefab).UnderTransform(canvas);
    }
}
