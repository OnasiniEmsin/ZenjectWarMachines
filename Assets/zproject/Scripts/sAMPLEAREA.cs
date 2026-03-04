using Zenject;
using UnityEngine;

public class sAMPLEAREA : MonoBehaviour
{
    public  Player player;
    [Inject]
    public void Construct(Player player){
        this.player=player;
    }

    
}
