using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    
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
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnRate, maxSpawnRate));
    }
}
