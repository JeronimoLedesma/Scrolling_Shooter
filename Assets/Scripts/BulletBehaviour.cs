using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxy;
    [SerializeField] float da�o;
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
            collision.collider.GetComponent<Enemy>().RecibirDa�o(da�o);
            Destroy(gameObject);
        }
    }
}
