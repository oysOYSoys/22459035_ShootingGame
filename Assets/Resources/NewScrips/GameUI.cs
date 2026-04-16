using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject startUI;
    public GameObject gameOverUI;

    void Start()
    {
        Time.timeScale = 0f;
        startUI.SetActive(true);
        gameOverUI.SetActive(false);
    }

    public void ClickPlayButton()
    {
        Time.timeScale = 1f;
        startUI.SetActive(false);
    }

    public void ShowGameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void ClickRestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}