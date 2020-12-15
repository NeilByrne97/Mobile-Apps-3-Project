using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public static CountdownTimer Instance;

    float currentTime;
    float startingtime = 200f;   // Amount of time player has to complete level
    private bool gameOver = false;
    private bool addTen = false;

    public GameObject gameOverSplash;
    public GameObject addTenSecsSplash;

    [SerializeField] Text countdownText;

    void Start()
    {
        Instance = this;
        currentTime = startingtime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;  // Remove a second every second
        countdownText.text =  currentTime.ToString();

        if (currentTime <= 10)
        {   // Warning
            countdownText.color = Color.red;
        }

        if(currentTime <=0)
        {
            Instance.gameOver = true;
        }
    }

    public static void AddTenSecs()
    {   // Called from Item Drop
        Instance.currentTime += 10;
        Instance.addTen = true;
    }


    private void OnGUI()
    {
        if (gameOver)
        {
            gameOverSplash.SetActive(true); // GAME OVER splash screen
            Time.timeScale = 0; // Stop game time
        }
        if (addTen)
        {
            addTenSecsSplash.SetActive(true);
            StartCoroutine(Wait());
            Instance.addTen = false;
        }

        IEnumerator Wait()
        {   // Set the splash for 1 second
            yield return new WaitForSeconds(1);
            addTenSecsSplash.SetActive(false);
        }

    }
}
