using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    GameObject gameObject;

    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject = GameObject.FindGameObjectWithTag("InfiniteAmmo"))
        {
            print("InfiniteAmmo");
            AmmoManager.InfiniteAmmo();
            Destroy(gameObject);
        } 
        else if (gameObject = GameObject.FindGameObjectWithTag("ExtraTime"))
        {
            Destroy(gameObject);
            CountdownTimer.AddTenSecs();
            print("ExtraTime");

        }
        else if (gameObject = GameObject.FindGameObjectWithTag("ExtraLife"))
        {
            Destroy(gameObject);
            HealthManager.AddHealth();
            print("ExtraLife");
        }



    }
}
