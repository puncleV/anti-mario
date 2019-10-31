using UnityEngine;

public class Health : MonoBehaviour
{
    [Range(100, 500)][SerializeField] private int hp = 100;

    public int Hp => hp;

    public void DealDamage(int damage)
    {
        hp -= damage;
        // play sound maybe
    }
}
