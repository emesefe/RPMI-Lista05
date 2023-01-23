using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public int[] intArray;
    private void Start()
    {
        Debug.Log($"First element = {intArray[0]}");
        Debug.Log($"Third element = {intArray[2]}");
        Debug.Log($"Fifth element = {intArray[4]}");
    }
}
