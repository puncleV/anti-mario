using UnityEngine;
using UnityEngine.Serialization;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject deathVfx;
    [SerializeField] private float vfxLifetime = 0.3f;
    [Range(100, 500)][SerializeField] private float hp = 100;

    public float Hp => hp;

    public void DealDamage(float damage)
    {
        hp -= damage;
        
        if (hp <= 0)
        {
            if (deathVfx != null)
            {
                var explosion = Instantiate(deathVfx, transform.position, Quaternion.identity);
                Destroy(explosion, vfxLifetime);
            }
            
            Destroy(gameObject);
        }
    }
}
