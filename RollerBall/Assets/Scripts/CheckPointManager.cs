using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().SetCurrentCheckpoint(transform.position);
    }
}
