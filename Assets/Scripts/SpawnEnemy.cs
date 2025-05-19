using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] float time;
    public GameObject[] enemies;
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
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
}
