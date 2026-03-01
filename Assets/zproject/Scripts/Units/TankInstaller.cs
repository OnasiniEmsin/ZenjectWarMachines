using UnityEngine;
using Zenject;

public class TankInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<Molot>()
            .FromComponentOnRoot()
            .AsSingle();
    }
    
}