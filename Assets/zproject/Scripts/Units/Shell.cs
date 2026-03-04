using UnityEngine;
using Zenject;
using System.Collections;

public class Shell : MonoBehaviour
{
    float _speed = 250f;
    public float _lifeTime=3f;

    public class Pool : MonoMemoryPool<Vector3, short, short, Shell> {
        protected override void Reinitialize(
        Vector3 pos,
        short x,
        short y,
        Shell bullet)
    {
        bullet.OnSpawned(pos, x, y);
    }
    }
    public short vert,hori;

    public void OnSpawned(Vector3 pos, short vert, short hori)
    {
        Debug.Log("Ola-la");
        transform.position = pos;
        this.vert=vert;this.hori=hori;
        gameObject.SetActive(true);
        StartCoroutine(LifeTimer());
    }

    void Update()
    {
        transform.Translate(hori * _speed * Time.deltaTime,vert* _speed * Time.deltaTime,0);
    }
    IEnumerator LifeTimer()
    {
        yield return new WaitForSeconds(_lifeTime);
        _pool.Despawn(this);
    }
    public void Despawn()
    {
        _pool.Despawn(this);
    }

    [Inject] Pool _pool;
}
