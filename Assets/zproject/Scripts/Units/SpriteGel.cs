using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGel :MonoBehaviour
{
    public short sideOfFront,sOTF;

    public GameObject[] hull,turret,gun;

    public Transform thisImageTransform,topOfHull,firePoint;

    protected void chooseSprite(){
        for(int i=0;i<hull.Length;i++){
            if(i==sideOfFront){
                hull[i].active=true;
            }else{
                hull[i].active=false;
            }
            if(i==sOTF){
                turret[i].active=true;
                thisImageTransform=turret[i].transform;
            }else{
                turret[i].active=false;
            }
        }
        thisImageTransform.position=topOfHull.position;
    }
}
