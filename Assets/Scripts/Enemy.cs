using UnityEngine;
using UnityEngine.VFX;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float life;
    [SerializeField] protected float speed;
    [SerializeField] protected GameObject drop;
    [SerializeField] protected float limitx;
    [SerializeField] protected float limity;
    [SerializeField] protected VisualEffect boom;
    [SerializeField] protected float boomTime;

    public abstract void Moverse();
    public abstract void RecibirDaño(float daño);


}
