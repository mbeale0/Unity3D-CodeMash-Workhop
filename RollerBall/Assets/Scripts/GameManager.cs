using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas = null;
    [SerializeField] private TMP_Text canvasText = null;
    void Start()
    {
        canvas.SetActive(false);
    }

    public void HandleGameOver(string textToDisplay)
    {
        canvasText.text = textToDisplay;
        canvas.SetActive(true);
        Time.timeScale = 0;
    }

}
