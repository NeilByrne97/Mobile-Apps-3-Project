using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;

    float currentScore;
    float startingScore = 0f;  

    [SerializeField] Text countdownText;

    void Start()
    {
        Instance = this;
        currentScore = startingScore;
    }

    public static void AddScore()
    {   // Called if +10 item is picked up
        Instance.currentScore += 10;
        Instance.countdownText.text = Instance.currentScore.ToString();
    }

}
