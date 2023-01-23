using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    private int counter;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddToCounter();
        }
    }

    private void AddToCounter()
    {
        counter++;
        if (counter >= 10)
        {
            Debug.Log("GAME OVER");
        }
    }
}
