using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour
{
    public GameObject gib = null;
    public int health = 2;


    private void OnCollisionEnter(Collision col)
    {
        health--;
        print("Health is " + health);
        if (health <= 0)
        {
            print("Dead");
            Destroy(gameObject);
            Instantiate(gib, transform.position, Quaternion.identity);
        }



      // Destroy(gameObject);
      // Instantiate(gib, transform.position, Quaternion.identity);
    }

}
