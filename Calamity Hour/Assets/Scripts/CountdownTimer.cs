using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public static CountdownTimer Instance;

    float currentTime;
    float startingtime = 2000f;   // Amount of time player has to complete level
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

    public static void AddTenSecs()
    {
        print("10 secs added");
        Instance.currentTime += 10;
        Instance.addTen = true;
        print("1");
    }


    private void OnGUI()
    {
        if (gameOver)
        {
            print("Game over");
            gameOverSplash.SetActive(true); // GAME OVER splash screen
            Time.timeScale = 0; // Stop game time
        }
        if (addTen)
        {
            print("2");
            addTenSecsSplash.SetActive(true);
            StartCoroutine(Wait());
            Instance.addTen = false;
        }

        IEnumerator Wait()
        {
            print("Waaait");
            yield return new WaitForSeconds(1);
            addTenSecsSplash.SetActive(false);
        }



    }
}
