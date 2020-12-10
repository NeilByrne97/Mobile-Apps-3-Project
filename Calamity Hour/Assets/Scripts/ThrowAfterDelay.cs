﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAfterDelay : MonoBehaviour
{
    public float delay = 1.0f;
    public GameObject throwingObject;
    public Transform throwPoint;
    public GameObject gib;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //Invoke("Throw", delay);
        gib.SetActive(false);
    }

    public void Throw()
    {
        print("Throwwwwing");
        Instantiate(throwingObject, throwPoint.position, Quaternion.LookRotation(Camera.main.transform.position - throwPoint.position));
        Instantiate(gib, transform.position, Quaternion.identity);

        //StartCoroutine(WaitActive());
        Invoke("Throw", delay);
        gib.SetActive(true);
        StartCoroutine(Wait());
    }

    IEnumerator WaitActive()
    {
        yield return new WaitForSeconds(1);
        Invoke("Throw", delay);
        gib.SetActive(true);
        StartCoroutine(Wait());

    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        gib.SetActive(false);
    }


}
