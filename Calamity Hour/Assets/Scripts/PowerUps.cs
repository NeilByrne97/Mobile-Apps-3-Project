using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    GameObject gameObject;

    private void OnCollisionEnter(Collision collision)
    {       // Check the tag of item destroyed
        if(gameObject = GameObject.FindGameObjectWithTag("InfiniteAmmo"))
        {
           // AmmoManager.InfiniteAmmo();
            Destroy(gameObject);
        } 
        else if (gameObject = GameObject.FindGameObjectWithTag("ExtraTime"))
        {
            Destroy(gameObject);
            CountdownTimer.AddTenSecs();

        }
        else if (gameObject = GameObject.FindGameObjectWithTag("ExtraLife"))
        {
            Destroy(gameObject);
            HealthManager.AddHealth();
        }



    }
}
