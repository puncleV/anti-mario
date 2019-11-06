using UnityEngine;
using UnityEngine.Serialization;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject deathVfx;
    [SerializeField] private float vfxLifetime = 0.3f;
    [Range(100, 500)][SerializeField] private int hp = 100;

    public int Hp => hp;

    public void DealDamage(int damage)
    {
        hp -= damage;
        
        if (hp <= 0)
        {
            var explosion = Instantiate(deathVfx, transform.position, Quaternion.identity);
            Destroy(explosion, vfxLifetime);
            Destroy(gameObject);
        }
    }
}
