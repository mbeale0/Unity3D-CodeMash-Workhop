using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Finished!");
        Time.timeScale = 0;
    }
}
