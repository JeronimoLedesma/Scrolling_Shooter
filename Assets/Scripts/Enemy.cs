using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float life;
    [SerializeField] protected float speed;
    [SerializeField] GameObject drop;
    [SerializeField] protected float limitx;
    [SerializeField] protected float limity;

    public abstract void Moverse();
    public void RecibirDaño(float daño)
    {
        life -= daño;
        if (life <= 0)
        {
            //particulas
            Destroy(gameObject);
        }
    }


}
