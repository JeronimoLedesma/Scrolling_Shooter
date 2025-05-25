using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.VFX;

public class PlayerScript : MonoBehaviour
{
    [Header("Move")]
    Vector2 moveInput;
    [SerializeField] float speed;
    [SerializeField] float limitx;
    [SerializeField] float limity;

    [Header("Shoot")]
    [SerializeField] GameObject bulletSpawner;
    [SerializeField] GameObject playerBullet;

    [Header("Life")]
    [SerializeField] float life;
    bool beingHit;
    [SerializeField] float stun;
    [SerializeField] Slider healthBar;

    [Header("Explode")]
    [SerializeField] VisualEffect boom;
    [SerializeField] float boomTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = life;
    }
    private void FixedUpdate()
    {
        Move();
    }

    public void OnMove (InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnShoot (InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject bullet = (GameObject)Instantiate(playerBullet);
            bullet.transform.position = bulletSpawner.transform.position;
        }
    }
    
    private void Move()
    {
        Vector3 pos = transform.position;
        pos += new Vector3(moveInput.x * speed * Time.deltaTime, moveInput.y * speed * Time.deltaTime, 0f);
        pos.x = Mathf.Clamp(pos.x, -limitx, limitx);
        pos.y = Mathf.Clamp(pos.y, -limity, limity);
        transform.position = pos;
    }

    IEnumerator hitStun()
    {
        beingHit = true;
        yield return new WaitForSeconds(stun);
        beingHit = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<EnemyBulletBeheavior>() != null)
        {
            if (!beingHit)
            {
                life -= collision.collider.GetComponent<EnemyBulletBeheavior>().daño;
                collision.collider.GetComponent<EnemyBulletBeheavior>().vfxPlay();
                if (life < 0)
                {
                    VisualEffect vfx = Instantiate(boom, transform);
                    Destroy(vfx.gameObject, boomTime);
                    SceneManager.LoadScene(2);
                }
                Destroy(collision.gameObject);
                StartCoroutine(hitStun());
            }
        }
        
    }
}
