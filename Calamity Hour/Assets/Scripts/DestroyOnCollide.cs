using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    public GameObject directionSplash;

    private void OnTriggerEnter(Collider other)
    {
        directionSplash.SetActive(true);
        //Destroy(gameObject); 
    }
}
