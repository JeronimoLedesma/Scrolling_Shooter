using UnityEngine;

public class EnemigoBoingo : Enemy
{
    bool derecha;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       int choose = Random.Range(0, 2);
        if (choose == 0)
        {
            derecha = true;
        }
        else
        {
            derecha = false;
        }
    }

    private void FixedUpdate()
    {
        Moverse();
    }

    public override void Moverse()
    {
        if (transform.position.x > limitx)
        {
            derecha = false;
        }
        if (transform.position.x < -limitx)
        {
            derecha = true;
        }
        if (derecha)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }

    public override void RecibirDa�o(float da�o)
    {
        Debug.Log("golpe");
        life -= da�o;
        if (life <= 0)
        {
            //particulas
            Destroy(gameObject);
        }
    }
}
