using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] private Defender defenderPrefab;
    private Color startColor;
    private void Start()
    {
        startColor = GetComponent<SpriteRenderer>().color;
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();

        foreach (var button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = button.startColor;
        }
        
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
