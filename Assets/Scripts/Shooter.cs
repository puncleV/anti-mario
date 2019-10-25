using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    public void Fire()
    {
        Instantiate(projectile, new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z),
            Quaternion.identity);
        

    }
}