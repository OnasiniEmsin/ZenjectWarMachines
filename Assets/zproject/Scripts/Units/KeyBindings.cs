using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class KeyBindings :MonoBehaviour
{
    byte sideOfFront;
    void Update(){
        if(Input.GetKey(KeyCode.W)){
            sideOfFront=2;
        }else{
            if(Input.GetKey(KeyCode.S)){
                sideOfFront=0;

            }
        }
        if(Input.GetKey(KeyCode.A)){
            sideOfFront=1;
        }else{
            if(Input.GetKey(KeyCode.D)){
                sideOfFront=3;

            }
        }
        molot.sOTF=sideOfFront;
    }
    [Inject]
    public Molot molot;


}
