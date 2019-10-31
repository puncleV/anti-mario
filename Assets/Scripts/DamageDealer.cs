using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private int damage = 100;

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
