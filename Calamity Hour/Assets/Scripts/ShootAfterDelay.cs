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
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponentInChildren<Animator>();
        Invoke("Throw", delay);
    }

    void Update()
    {
        Invoke("Throw", delay);

        //animator.SetBool("Throw", false);
    }

    void Shoot()
    {
        Instantiate(throwingObject, throwPoint.position, Quaternion.LookRotation(Camera.main.transform.position - throwPoint.position));
        //animator.SetBool("Throw", true);

        Invoke("Throw", delay);

    }

   

}
