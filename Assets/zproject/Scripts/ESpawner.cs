using UnityEngine;
using Zenject;

public class ESpawner : MonoInstaller
{
    [SerializeField] private GameObject enemyPrefab;
    public override void InstallBindings()
    {
        GameObject enemy=Instantiate(enemyPrefab);
    }
}