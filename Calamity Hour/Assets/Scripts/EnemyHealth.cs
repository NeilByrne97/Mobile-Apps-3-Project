using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    EnemyHealth enemy0;
    public GameObject gib = null;

    public int health=2;

    public void OnCollisionEnter(Collision collision)
    {
        enemy0.health--;
        if(enemy0.health <= 0)
        {
            Destroy(gameObject);
            Instantiate(gib, transform.position, Quaternion.identity);

        }

    }

}
