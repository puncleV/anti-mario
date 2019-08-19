using System;
using System.Collections;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private float loadingDelay = 3f;
    private void Start()
    {
        StartCoroutine(loadMainMenu());
    }

    IEnumerator loadMainMenu()
    {
        yield return new WaitForSeconds(loadingDelay);
        
        FindObjectOfType<SceneLoader>().MainMenu();
    }
}
