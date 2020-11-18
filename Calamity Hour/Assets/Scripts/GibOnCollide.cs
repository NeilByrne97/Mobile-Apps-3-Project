using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour
{
    public GameObject gib = null;

    private void OnCollisionEnter(Collision col)
    {
        print("Collision Entered with " + col);
        Destroy(gameObject);
        Instantiate(gib, transform.position, Quaternion.identity);
    }

}
