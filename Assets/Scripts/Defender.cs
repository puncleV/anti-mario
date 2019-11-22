using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] private int cost = 100;

    public void AddStars(int amount)
    {
        var starDisplay = FindObjectOfType<StarDisplay>();
        
        starDisplay.AddStars(amount);
    }
}
