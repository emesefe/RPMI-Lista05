using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public int[] intArray;
    private void Start()
    {
        if (intArray.Length >= 5)
        {
            Debug.Log($"First element = {intArray[0]}");
            Debug.Log($"Third element = {intArray[2]}");
            Debug.Log($"Fifth element = {intArray[4]}"); 
        }
        else
        {
            Debug.Log("Missing elements.");
        }
        
    }
}
