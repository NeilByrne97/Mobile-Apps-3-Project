using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;

    public int startingHealth = 3;
    public GameObject[] healthIcons;

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
            Instance.healthIcons[Instance.currentHealth].SetActive(false);
        }

        // Game Over
        if(Instance.currentHealth <= 0)
        {
            Instance.gameOver = true;
        }

    }

    private void OnGUI()
    {
        if (gameOver)
        {
            GUILayout.Label("Game Over");
        }
    }
}
