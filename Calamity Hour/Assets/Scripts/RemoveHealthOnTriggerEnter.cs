using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHealthOnTriggerEnter : MonoBehaviour
{
    void OnTriggerEnter()
    {
        HealthManager.RemoveHealth();
    }
}
