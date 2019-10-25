using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int damage = 100;
    [SerializeField] private float speed = 5f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }
}
