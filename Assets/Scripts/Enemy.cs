using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float life;
    [SerializeField] protected float speed;
    [SerializeField] GameObject drop;
    [SerializeField] protected float limitx;
    [SerializeField] protected float limity;

    public abstract void Moverse();
    public abstract void RecibirDaño(float daño);


}
