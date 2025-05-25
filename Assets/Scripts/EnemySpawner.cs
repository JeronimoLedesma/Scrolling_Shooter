using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] float time;
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnEnemy()
    {
        
        while (true)
        {
            GameObject enemy = (GameObject)Instantiate(enemies[Random.Range(0, enemies.Length)]);
            enemy.transform.position = new Vector2(Random.Range(-maxX, maxX), maxY);

            yield return new WaitForSeconds(time);
        }
    }
}
