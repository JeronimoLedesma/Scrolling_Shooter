using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(2,2));

        if (transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
    }
}
