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

    private int numberOfCoins = 0;
    void Start()
    {
        gameOverCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        coinText.text = $"Coins: {numberOfCoins}";
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
    }

}
