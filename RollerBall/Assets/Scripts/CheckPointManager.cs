using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    private AudioSource audioSource = null;
    private GameManager gameManager = null;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {        
        if(gameManager.GetCurrentcheckpoint() != transform.position)
        {
            //audioSource.Play();
            Debug.Log("Why?");
            gameManager.SetCurrentCheckpoint(transform.position);
        }
    }
}
