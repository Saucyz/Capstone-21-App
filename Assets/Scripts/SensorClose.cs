﻿using UnityEngine;
using System.Collections;

public class SensorClose : MonoBehaviour
{

    public GameObject sensor; // Assign in inspector
    private bool isShowing;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            //menu.SetActive(isShowing);
        }
    }
}