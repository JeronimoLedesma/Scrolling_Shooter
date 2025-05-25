using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] float time;
    public GameObject[] enemies;
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    [SerializeField] float accel;
    [SerializeField] float accelRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
        StartCoroutine(XLR8());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject enemy = (GameObject)Instantiate(enemies[Random.Range(0, enemies.Length)]);
            enemy.transform.position = new Vector3 (Random.Range(-maxX, maxX), maxY, transform.position.z);
            yield return new WaitForSeconds(time);
        }
    }

    IEnumerator XLR8()
    {
        yield return new WaitForSeconds(accel);
        time = time*accelRate;
    }
}
