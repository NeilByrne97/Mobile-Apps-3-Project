using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour
{
    public GameObject item;
    public GameObject gib;
    public AudioSource audioSrc;
    public AudioClip deathClip;

    public int health = 2;  // Medium enemies health, config for other enemies

    private void OnCollisionEnter(Collision col)
    {
        health--;
        if (health <= 0)
        {
            item.GetComponent<GameObject>();    // Item drop
            item.SetActive(true);   // If they have one then drop it
            Destroy(gameObject);
            Instantiate(gib, transform.position, Quaternion.identity);
            audioSrc.PlayOneShot(deathClip);
            ScoreCounter.AddScore(); // When enemy dies add to the player score
        }

}

}
