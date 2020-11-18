using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingtime = 20f;

    [SerializeField] Text countdownText;

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
    }
}
