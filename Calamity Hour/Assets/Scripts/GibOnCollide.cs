using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour
{
    public GameObject gib;

    private void OnCollisionEnter(Collision col)
    {
        print("Collision Entered");
        Destroy(gameObject);
        Instantiate(gib, transform.position, Quaternion.identity);
        
    }

}
