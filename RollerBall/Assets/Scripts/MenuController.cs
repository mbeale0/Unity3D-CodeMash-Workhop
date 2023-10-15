using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject pauseCanvas = null;
    public void OnRestart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level1");
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnResume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
