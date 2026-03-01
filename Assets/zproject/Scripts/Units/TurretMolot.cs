using Zenject;
using UnityEngine;

public class TurretMolot : MonoBehaviour,ITurret
{
    public Transform firePoint;
    [Inject]
    Molot molot;
    void OnEnable(){
        molot.firePoint=firePoint;
    }
}
