using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody rigidBody = null;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        
    }
}
