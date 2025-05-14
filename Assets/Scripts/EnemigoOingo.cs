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
}
