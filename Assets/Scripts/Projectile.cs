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
        Health health = collider.gameObject.GetComponent<Health>();

        health.DealDamage(damage);

        if (health.Hp <= 0)
        {
            Destroy(collider.gameObject);    
        }
        
        Destroy(gameObject);
    }
}
