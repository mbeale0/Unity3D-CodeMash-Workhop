using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverCanvas = null;
    [SerializeField] private TMP_Text gameOverText = null;
    [SerializeField] private TMP_Text coinText = null;
    [SerializeField] private GameObject pauseCanvas = null;
    [SerializeField] private TMP_Text livesText = null;
    [SerializeField] private TMP_Text timerText = null;
    [SerializeField] private Transform start = null;
    [SerializeField] private Transform player = null;

    private int numberOfCoins = 0;
    private int lives = 1;
    private Vector3 checkpoint = Vector3.zero;
    private int currentMinutes = 0;
    private int currentSeconds = 0;
    private float currentMilliseconds = 0;

    void Start()
    {
        gameOverCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        coinText.text = $"Coins: {numberOfCoins}";
        livesText.text = $"Lives: {lives}";
        timerText.text = "00:00:00";
    }

    private void Update()
    {
        currentMilliseconds += Time.deltaTime * 100;

        if(currentMilliseconds >= 100)
        {
            currentMilliseconds = 0;
            currentSeconds++;
        }
        if (currentSeconds >= 60)
        {
            currentSeconds = 0;
            currentMinutes++;
        }

        string minutesText = currentMinutes.ToString("D2");
        string secondsText = currentSeconds.ToString("D2");

        timerText.text = $"{minutesText}:{secondsText}:{Mathf.Round(currentMilliseconds)}";
    }

    public void HandleGameOver(string textToDisplay)
    {
        gameOverText.text = textToDisplay;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void HandlePause()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }

    public void AddCoin()
    {
        numberOfCoins++;
        coinText.text = $"Coins: {numberOfCoins}";
        if(numberOfCoins % 2 == 0)
        {
            lives++;
            livesText.text = $"Lives: {lives}";
        }
    }

    public void SetCurrentCheckpoint(Vector3 position)
    {
        checkpoint = position;
    }
    public void Respawn()
    {
        lives--;
        livesText.text = $"Lives: {lives}";
        if (lives < 0)
        {
            HandleGameOver("You lose!");
        }
        else
        {
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            player.position = new Vector3(checkpoint.x, checkpoint.y + 5, checkpoint.z);
        }
    }

}
