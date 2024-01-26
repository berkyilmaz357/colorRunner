using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    void Start()
    {
        // Ba�lang��ta "game over" ekran�n� gizle
        HideGameOverUI();
    }

    void Update()
    {
        // "delete" tag'ine sahip obje silindi�inde "game over" ekran�n� g�ster
        if (ObjectDeleted())
        {
            ShowGameOverUI();
        }
    }

    bool ObjectDeleted()
    {
        // "delete" tag'ine sahip obje silindi�inde true d�nd�r
        return GameObject.FindGameObjectWithTag("delete") == null;
    }

    void ShowGameOverUI()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f; // Oyun zaman�n� durdur
    }

    void HideGameOverUI()
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1f; // Oyun zaman�n� geri ba�lat
    }

    public void RestartGame()
    {
        // Oyunu yeniden ba�latmak i�in sahneyi tekrar y�kle
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
