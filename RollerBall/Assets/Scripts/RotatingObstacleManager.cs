using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotatingObstacleManager : MonoBehaviour
{    
    [SerializeField] private float speed = 15.0f;
    [SerializeField] private bool rotateClockWise = true;
    private void Start()
    {
        if (!rotateClockWise)
        {
            speed = -speed;
        }
    }
    private void Update()
    {
        gameObject.transform.Rotate(new Vector3 (0, 1, 0) * speed * Time.deltaTime);
    }
}

