using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        var sprite = GetComponent<SpriteRenderer>();
        
        sprite.color = Color.white;
    }
}
