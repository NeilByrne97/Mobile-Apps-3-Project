using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public CountdownTimer Instance;

    float currentTime = 0f;
    float startingtime = 20f;   // Amount of time player has to complete level
    private bool gameOver = false;

    public GameObject gameOverSplash;

    [SerializeField] Text countdownText = null;

    void Start()
    {
        currentTime = startingtime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text =  currentTime.ToString();

        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
        }

        if(currentTime <=0)
        {
            Instance.gameOver = true;
        }
    }


    private void OnGUI()
    {
        if (gameOver)
        {
            print("Game over");
            gameOverSplash.SetActive(true); // GAME OVER splash screen
            Time.timeScale = 0; // Stop game time
        }
    }
}
