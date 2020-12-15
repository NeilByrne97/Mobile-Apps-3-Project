using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    public GameObject directionSplash;
    private void OnTriggerEnter(Collider other)
    {
        // Trigger the text while next level plays
        directionSplash.SetActive(true);
        Destroy(gameObject);
    }
}
