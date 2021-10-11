using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)][SerializeField] private float speed = 1f; 
    [Range(100, 300)][SerializeField] private int hp = 100;


    private Defender currentTarget;
    
    private static readonly int IsAttacking = Animator.StringToHash("isAttacking");

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.left);
        UpdateAnimationState();
    }

    void SetMovementSpeed(float speed)
    {
        this.speed = speed;
    }

    public void Attack(Defender target)
    {
        GetComponent<Animator>().SetBool(IsAttacking, true);

        currentTarget = target;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject collidedWith = other.gameObject;

        Defender defender = collidedWith.GetComponent<Defender>();

        if (defender != null)
        {
            Attack(defender);
        }
    }
    
    public void StrikeCurrentTarget(float damage) {
        if(!currentTarget) {return;}

        Health health = currentTarget.GetComponent<Health>();

        if (health)
        {
            health.DealDamage(damage);
        }
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool(IsAttacking, false);
        }
    }
}
