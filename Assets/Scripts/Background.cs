using System.Collections;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float delay;
    Vector3 initialPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
        StartCoroutine(ResetPosition());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
    }

    IEnumerator ResetPosition()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            transform.position = initialPosition;
        }
    }
}
