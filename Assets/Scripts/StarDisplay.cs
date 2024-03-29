﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] private int stars = 100;

    public int Stars => stars;

    private Text starText;
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void AddStars(int count)
    {
        stars += count;
        UpdateDisplay();
    }

    public void SpendStars(int count)
    {
        if (stars - count < 0) throw new ArgumentOutOfRangeException();
        
        stars -= count;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
}
