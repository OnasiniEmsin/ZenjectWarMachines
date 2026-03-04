using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molot :  SpriteGel,IUnit,IMoveTank
{
    bool isMoving;
    public bool ready=false;
    public float moveSpeed;
    public IReloader ammoLoader;

    public IHEalth health;
    

    // Update is called once per frame
    void Update()
    {
        desiring();
        chooseSprite();
        MoveMethod();
    }


    void desiring(){
        isMoving=false;
        if(Input.GetKey(KeyCode.UpArrow)){
            sideOfFront=2;
            isMoving=true;
        }else{
            if(Input.GetKey(KeyCode.DownArrow)){
                sideOfFront=0;
                isMoving=true;
            }
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            sideOfFront=1;
            isMoving=true;
        }else{
            if(Input.GetKey(KeyCode.RightArrow)){
                sideOfFront=3;
                isMoving=true;
            }
        }
    }


    public void MoveMethod(){
        if(isMoving){
            switch(sideOfFront){
                case 0:MoveVertical(-1);break;
                case 1:MoveHorizontal(-1);break;
                case 2:MoveVertical(1);break;
                case 3:MoveHorizontal(1);break;
            }
        }
    }
    void MoveVertical(short i){
        transform.Translate(0,i*moveSpeed*Time.deltaTime,0);
    }
    void MoveHorizontal(short i){
        transform.Translate(i*moveSpeed*Time.deltaTime,0,0);
    }
    public void fire(){
        ready=false;
        ammoLoader.reload();
    }
}
