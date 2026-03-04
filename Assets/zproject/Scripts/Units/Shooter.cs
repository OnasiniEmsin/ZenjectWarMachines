using UnityEngine;
using Zenject;

public class Shooter : MonoBehaviour
{
    [Inject] 
    public void Construct(Shell.Pool bp,Molot molot){
        _bulletPool=bp;this.molot=molot;
    }
    Shell.Pool _bulletPool;

    public Transform firePoint;

    public Molot molot;

    protected void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&molot.ready)
        {
            molot.fire();
            firePoint =molot.firePoint;
            Debug.Log(_bulletPool);
            _bulletPool.Spawn(
            firePoint.position,desiring((short)(molot.sOTF+1)),
            (short)desiring(molot.sOTF)
            
            );
        }
    }
    short desiring(short i){
        if(i%2==0){
            return 0;
        }else{
            if(i>2){
            return 1;
            }else{
                return -1;
            }
        }
    }
}