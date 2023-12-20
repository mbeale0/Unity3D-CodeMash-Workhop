using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineManager : MonoBehaviour
{
    private AudioSource audioSource = null;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().HandleGameOver("You Win!!!");
    }
}
