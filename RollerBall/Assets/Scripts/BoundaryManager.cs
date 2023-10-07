using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You lose!");
        Time.timeScale = 0;
    }
}
