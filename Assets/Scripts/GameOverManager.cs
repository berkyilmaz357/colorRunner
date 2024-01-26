using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    void Start()
    {
        // Baþlangýçta "game over" ekranýný gizle
        HideGameOverUI();
    }

    void Update()
    {
        // "delete" tag'ine sahip obje silindiðinde "game over" ekranýný göster
        if (ObjectDeleted())
        {
            ShowGameOverUI();
        }
    }

    bool ObjectDeleted()
    {
        // "delete" tag'ine sahip obje silindiðinde true döndür
        return GameObject.FindGameObjectWithTag("delete") == null;
    }

    void ShowGameOverUI()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f; // Oyun zamanýný durdur
    }

    void HideGameOverUI()
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1f; // Oyun zamanýný geri baþlat
    }

    public void RestartGame()
    {
        // Oyunu yeniden baþlatmak için sahneyi tekrar yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
