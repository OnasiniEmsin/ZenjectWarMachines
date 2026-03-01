using UnityEngine;
using Zenject;

public class MojInstaller : MonoInstaller
{
    public GameObject tankPrefab;
    public Transform spawnPoint;
    
    public override void InstallBindings()
    {
        Debug.Log("bbb");
        var molot=Container.InstantiatePrefabForComponent<Molot>(tankPrefab,spawnPoint.position,Quaternion.identity,spawnPoint);
        Container.BindInterfacesAndSelfTo<Molot>().FromInstance(molot).AsSingle();
        
        
    }
}