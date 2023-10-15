using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private Rigidbody rigidBody = null;
    private int MoveX = 0;
    private int MoveZ = 0;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }



    void Update()
    {        
        if (Input.GetKey(KeyCode.W))
        {
            MoveZ = -1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveZ = 1;
        }
        else
        {
            MoveZ = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveX = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MoveX = -1;
        }
        else
        {
            MoveX = 0;
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().HandlePause();
        }
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(new Vector3(MoveX, 0, MoveZ) * speed);
    }
}
