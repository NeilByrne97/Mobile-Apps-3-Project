using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAfterDelay : MonoBehaviour
{
    public float delay = 1.0f;
    public GameObject throwingObject;

    private GameObject player;
    private Animator animator;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponentInChildren<Animator>();
        Invoke("Throw", delay);
    }

    void LateUpdate()
    {
        animator.SetBool("Shoot", false);
    }

    void Throw()
    {
        Instantiate(throwingObject, transform.position, Quaternion.LookRotation(player.transform.position - transform.position));
        animator.SetBool("Throw", true);

        Invoke("Throw", delay);
    }

}
