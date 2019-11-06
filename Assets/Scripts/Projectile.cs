using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private int damage = 100;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }
    
    public void OnTriggerEnter2D(Collider2D collider)
    {
        var health = collider.gameObject.GetComponent<Health>();
        var attacker = collider.gameObject.GetComponent<Attacker>();

        if (!attacker || !health) return;
        
        health.DealDamage(damage);
        Destroy(gameObject);
    }
}
