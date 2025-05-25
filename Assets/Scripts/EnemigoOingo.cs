using UnityEngine;
using UnityEngine.VFX;

public class EnemigoOingo : Enemy
{
    private void FixedUpdate()
    {
        Moverse();
    }

    public override void Moverse()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        if (transform.position.y < -limity)
        {
            Destroy(gameObject);
        }
    }

    public override void RecibirDaño(float daño)
    {
        life -= daño;
        if (life <= 0)
        {
            GameObject droppin = (GameObject)Instantiate(drop);
            droppin.transform.position = gameObject.transform.position;
            VisualEffect vfx = Instantiate(boom, transform);
            Destroy(vfx, boomTime);
            Destroy(gameObject);
        }
    }
}
