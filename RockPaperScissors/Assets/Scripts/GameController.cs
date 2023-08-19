using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int count = 0;
    public void OnCount()
    {
        count++;
        Debug.Log($"Count: {count}");
    }
}
