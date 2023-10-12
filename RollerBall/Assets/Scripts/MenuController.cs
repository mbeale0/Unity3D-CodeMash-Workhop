using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnRestart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level1");
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
