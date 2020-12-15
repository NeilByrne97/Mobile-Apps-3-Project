using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour
{
    public GameObject item;
    public GameObject gib;
    public AudioSource audioSrc;
    public AudioClip deathClip;

    public int health = 2;

    private void OnCollisionEnter(Collision col)
    {
        health--;
       // print("Health is " + health);
        if (health <= 0)
        {
            item.GetComponent<GameObject>();    // Item drop
            print("Dropped");
            item.SetActive(true);
            Destroy(gameObject);
            Instantiate(gib, transform.position, Quaternion.identity);
            audioSrc.PlayOneShot(deathClip);
            ScoreCounter.AddScore();
        }



    // Destroy(gameObject);
    // Instantiate(gib, transform.position, Quaternion.identity);
}

}
