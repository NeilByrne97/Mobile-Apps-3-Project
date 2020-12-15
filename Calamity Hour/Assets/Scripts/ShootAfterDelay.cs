using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAfterDelay : MonoBehaviour
{
    public float delay = 1.0f;
    public GameObject throwingObject;
    public Transform throwPoint;

    private GameObject player;
    private Animator animator;

    void Start()
    {       // Wait for the given amount of seconds then shoot player
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponentInChildren<Animator>();
        Invoke("Throw", delay);
    }

    void Update()
    {
        Invoke("Throw", delay);
    }

    void Shoot()
    {
        Instantiate(throwingObject, throwPoint.position, Quaternion.LookRotation(Camera.main.transform.position - throwPoint.position));
        Invoke("Throw", delay);

    }

   

}
