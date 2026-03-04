using Zenject;
using UnityEngine;

public class TankHealth : MonoBehaviour,IHEalth
{
    public int Health = 100;
    [Inject]
    public void Construct(Molot molot)
    {
        this.molot = molot;
        molot.health = this;
    }
    Molot molot;
    public void damage(int i)
    {
        Health -= i;
    }
    public void heal(int i)
    {
        Health += i;
    }
}
