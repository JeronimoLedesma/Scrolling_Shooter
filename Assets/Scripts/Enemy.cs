using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float life;
    [SerializeField] protected float speed;
    [SerializeField] GameObject drop;
    [SerializeField] protected float limitx;
    [SerializeField] protected float limity;

    public abstract void Moverse();
    public void RecibirDa�o(float da�o)
    {
        life -= da�o;
        if (life <= 0)
        {
            //particulas
            Destroy(gameObject);
        }
    }


}
