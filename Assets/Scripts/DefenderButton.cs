using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private Color startColor;
    private void Start()
    {
        startColor = GetComponent<SpriteRenderer>().color;
    }

    private void OnMouseDown()
    {
        var sprite = GetComponent<SpriteRenderer>();
        
        sprite.color = Color.white;
    }

    private void OnMouseUp()
    {
        var sprite = GetComponent<SpriteRenderer>();
        
        sprite.color = startColor;
    }
}
