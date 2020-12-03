using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    public GameObject directionSplash;
    private void OnTriggerEnter(Collider other)
    {
        print("Endpoint Entered");
        directionSplash.SetActive(true);
        Destroy(gameObject);
    }
}
