using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    private bool Login(string username, string password)
    {
        if (username == "admin" && password == "abccba")
        {
            return true;
        }
        return false;
    }
}
