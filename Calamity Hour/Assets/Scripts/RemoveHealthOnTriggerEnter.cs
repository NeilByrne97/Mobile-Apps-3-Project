using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHealthOnTriggerEnter : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        print("Player hit");
        HealthManager.RemoveHealth();
    }
}
