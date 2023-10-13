using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().HandleGameOver("You Win!!!");
    }
}
