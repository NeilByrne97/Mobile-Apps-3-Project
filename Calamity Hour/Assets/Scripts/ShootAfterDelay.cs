using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAfterDelay : MonoBehaviour
{
    public float delay = 1.0f;
    private Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        Invoke("Shoot", delay);
    }

    void Update()
    {
        animator.SetBool("Shoot", false);

    }

    void Shoot()
    {
        // Deal damage to player

        animator.SetBool("Shoot", true);
    }

}
