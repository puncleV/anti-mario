using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }
    
   
}
