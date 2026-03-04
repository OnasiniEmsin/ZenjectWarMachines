using UnityEngine;
using Zenject;

public class MojInstaller : MonoInstaller
{
    public GameObject tankPrefab,btrPrefab;
    public Transform spawnPoint;
    
    public override void InstallBindings()
    {
        Debug.Log("bbb");var molot=Container.InstantiatePrefabForComponent<Molot>(btrPrefab,spawnPoint.position,Quaternion.identity,spawnPoint);
        //var molot=Container.InstantiatePrefabForComponent<Molot>(tankPrefab,spawnPoint.position+Vector3.up*50,Quaternion.identity,spawnPoint);
        Container.BindInterfacesAndSelfTo<Molot>().FromInstance(molot).AsSingle();

        
        
        
        
    }
}