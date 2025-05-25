using UnityEngine;
using UnityEngine.VFX;

public class EnemyBulletBeheavior : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 direccion;
    bool preparado;
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    [SerializeField] public float daño;
    [SerializeField] VisualEffect spark;
    [SerializeField] float vfxTime;
    
    private void Awake()
    {
        preparado = false;
    }

    private void FixedUpdate()
    {
        if (preparado)
        {
            Vector3 posicion = transform.position;
            posicion += direccion * speed * Time.deltaTime;
            transform.position = posicion;

            if (transform.position.x < -maxX || transform.position.x > maxX || transform.position.y < -maxY || transform.position.y > maxY)
            {
                Destroy(gameObject);
            }
        }
    }

    public void SetDireccion(Vector2 direction)
    {
        direccion = direction.normalized;
        preparado = true;
    }

    public void vfxPlay()
    {
        VisualEffect vfx = Instantiate(spark, transform.position, Quaternion.identity);
        Destroy(vfx.gameObject, vfxTime);
    }
}
