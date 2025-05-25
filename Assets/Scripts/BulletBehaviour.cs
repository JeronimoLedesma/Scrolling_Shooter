using UnityEngine;
using UnityEngine.VFX;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxy;
    [SerializeField] float daño;
    [SerializeField] VisualEffect spark;
    [SerializeField] float vfxTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);

        if (transform.position.y > maxy)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Enemy>() != null)
        {
            VisualEffect vfx = Instantiate(spark, transform.position, Quaternion.identity);
            Destroy(vfx.gameObject, vfxTime);
            collision.collider.GetComponent<Enemy>().RecibirDaño(daño);
            Destroy(gameObject);
        }
    }
}
