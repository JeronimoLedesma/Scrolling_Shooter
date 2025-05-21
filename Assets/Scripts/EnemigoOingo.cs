using UnityEngine;

public class EnemigoOingo : Enemy
{
    private void FixedUpdate()
    {
        Moverse();
    }

    public override void Moverse()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        if (transform.position.y < limity)
        {
            Destroy(gameObject);
        }
    }

    public override void RecibirDaño(float daño)
    {
        Debug.Log("golpe");
        life -= daño;
        if (life <= 0)
        {
            //particulas
            Destroy(gameObject);
        }
    }
}
