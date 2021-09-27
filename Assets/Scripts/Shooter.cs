using System;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject gun;

    private AttackerSpawner lineSpawner;
    private static readonly int Attacking = Animator.StringToHash("attacking");

    private void Start()
    {
        SetLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
           GetComponent<Animator>().SetBool(Attacking, true);
        }
        else
        {
            GetComponent<Animator>().SetBool(Attacking, false);

        }
    }

    private bool IsAttackerInLane()
    {
        return lineSpawner.transform.childCount > 0;
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in attackerSpawners)
        {
            if (Math.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon)
            {
                lineSpawner = spawner;
            }
        }
    }
    
    public void Fire()
    {
        Instantiate(projectile, gun.transform.position,
            Quaternion.identity);
    }
}
