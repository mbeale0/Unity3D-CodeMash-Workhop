using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private AudioClip pickupSFX = null;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(pickupSFX, transform.position, 1);       
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameManager.AddCoin();
        Destroy(gameObject);
    }
}
