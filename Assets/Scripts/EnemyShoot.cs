using System.Collections;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletEnemy;
    [SerializeField] float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FireBullet());
    }

    IEnumerator FireBullet()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        while (true)
        {
            if (player != null)
            {
                GameObject bullet = (GameObject)Instantiate(bulletEnemy);
                bullet.transform.position = transform.position;
                Vector2 direccion = player.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBulletBeheavior>().SetDireccion(direccion);
                yield return new WaitForSeconds(time);
            }
        }
    }
}
