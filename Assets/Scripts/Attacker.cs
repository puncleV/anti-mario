using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)][SerializeField] private float speed = 1f; 
    [Range(100, 300)][SerializeField] private int hp = 100; 
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.left);
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Projectile damageDealer = collider.gameObject.GetComponent<Projectile>();

        if (!damageDealer)
        {
            return;
        }

        handleHit(damageDealer);
    }

    private void handleHit(Projectile projectile)
    {
        hp -= projectile.Damage;
        
        projectile.hit();

        if (hp <= 0)
        {
            die();
        }
    }

    private void die()
    {
//        AudioSource.PlayClipAtPoint(deathSound, transform.position);
        Destroy(gameObject);
    }
}
