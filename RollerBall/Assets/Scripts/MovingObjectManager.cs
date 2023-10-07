using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectManager : MonoBehaviour
{
    [Range(-1, 1)]
    [SerializeField] private float movementMultiplier = 0f;
    [SerializeField] private float movementRange = 7f;
    [SerializeField] private bool startMovePositive = true;

    private float startXPosition = 0f;
    private bool movingPositive = true;
    private void Start()
    {
        startXPosition = transform.position.x;
        movingPositive = startMovePositive;
    }

    void Update()
    {
        
        if (transform.position.x >= startXPosition + movementRange)
        {
            movingPositive = false;    
        }
        else if(transform.position.x <= startXPosition - movementRange){
            movingPositive = true;
        }
        if (movingPositive)
        {
            movementMultiplier += Time.deltaTime;
        }
        else
        {
            movementMultiplier -= Time.deltaTime;
        }
        float currentOffset = movementRange * movementMultiplier;
        float newXPosition = startXPosition + currentOffset;
        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
    }
}
