using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int damage = 100;
    [SerializeField] private float speed = 5f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }
    
    public int Damage
    {
        get => damage;
        set => damage = value;
    }

    public void hit()
    {
        Destroy(gameObject);
    }
}
