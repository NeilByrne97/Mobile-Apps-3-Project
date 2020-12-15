using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAfterDelay : MonoBehaviour
{
    public float delay = 1.0f;
    public GameObject throwingObject;
    public Transform throwPoint;

    public AudioSource audioSrc;
    public AudioClip throwClip;

    public GameObject gib;

    private GameObject player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gib.SetActive(false);   // Don't want enemies throwing on awake
    }

    public void Throw()
    {
        audioSrc.PlayOneShot(throwClip);
        Instantiate(throwingObject, throwPoint.position, Quaternion.LookRotation(Camera.main.transform.position - throwPoint.position));
        Instantiate(gib, transform.position, Quaternion.identity);
        // Throw on configed delay
        Invoke("Throw", delay);
        gib.SetActive(true);
        // Wait a second and turn it off again so delay can be invoked again
        StartCoroutine(Wait());
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        gib.SetActive(false);
    }


}
