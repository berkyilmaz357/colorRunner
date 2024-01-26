using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    void Start()
    {
        
        HideGameOverUI();
    }

    void Update()
    {
        
        if (ObjectDeleted())
        {
            ShowGameOverUI();
        }
    }

    bool ObjectDeleted()
    {
        
        return GameObject.FindGameObjectWithTag("delete") == null;
    }

    void ShowGameOverUI()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f; 
    }

    void HideGameOverUI()
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1f; 
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
