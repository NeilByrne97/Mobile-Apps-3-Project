using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Functionally identical to HealthManager script
public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;

    public int startingHealth = 3;
    public GameObject[] healthIcons;
    public GameObject gameOverSplash;

    private int currentHealth;
    private bool gameOver = false;

    void Start()
    {
        Instance = this;
        currentHealth = startingHealth;
    }

    public static void RemoveHealth()
    {
        Instance.currentHealth--;

        if(Instance.currentHealth >= 0)
        {
            Instance.healthIcons[Instance.currentHealth].SetActive(false); // Remove heart icon
        }

        // Game Over
        if(Instance.currentHealth <= 0)
        {
            Instance.gameOver = true;
        }
    }

    public static void AddHealth()
    {
        Instance.currentHealth++;

        if (Instance.currentHealth >= 0)
        {
            Instance.healthIcons[Instance.currentHealth].SetActive(true); // Add hearth icon
        }

    }

    private void OnGUI()
    {
        if (gameOver)
        {
            gameOverSplash.SetActive(true); // GAME OVER splash screen
            SoundManager.playSound();
            Time.timeScale = 0; // Stop game time
        }
    }
}
