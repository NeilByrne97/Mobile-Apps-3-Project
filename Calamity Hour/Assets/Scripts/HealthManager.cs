using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;

    public int startingHealth = 3;
    public GameObject[] healthIcons;

    private int currentHealth;

    void Start()
    {
        Instance = this;
        currentHealth = startingHealth;
    }

    void Update()
    {
        
    }

    public static void RemoveHealth()
    {
        Instance.currentHealth--;
        Instance.healthIcons[Instance.currentHealth].SetActive(false);

    }
}
