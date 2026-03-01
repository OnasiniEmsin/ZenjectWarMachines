
using UnityEngine;
using Zenject;

public class MyElement : MonoBehaviour
{
    public SpriteGel sg;
    [Inject]
    public void Construct(Molot sg){
        Debug.Log("AAa");
        this.sg=sg;
    }
    
    public Transform myElement;
    void OnEnable(){
        sg.topOfHull=myElement;
    }
}
