using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AttackerSpawner : MonoBehaviour
{
    [FormerlySerializedAs("enemyPrefab")] [SerializeField] private Attacker attackerPrefab;
    [SerializeField] private Boolean on = true;
    
    [SerializeField] private float minSpawnRate = 1f;
    [SerializeField] private float maxSpawnRate = 5f;

    
    private Coroutine spawnCoroutine = null;
    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(spawn());
        } while (on);
    }

    IEnumerator spawn()
    {
        Attacker attacker = Instantiate(attackerPrefab, transform.position, Quaternion.identity);

        attacker.transform.parent = transform;
        
        yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnRate, maxSpawnRate));
    }
}
