using Zenject;
using System.Collections;
using UnityEngine;

public class Reloader : MonoBehaviour,IReloader
{
    public float reloadTime;
    public Molot molot;
    [Inject]
    public void Construct(Molot molot){
        this.molot=molot;
        molot.ammoLoader=this;
    }
    public void reload(){
        StartCoroutine(reloadIenumerator());
    }
    IEnumerator reloadIenumerator(){
        yield return new WaitForSeconds(reloadTime);
        molot.ready=true;
    }
}
