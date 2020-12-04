using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAfterDelay : MonoBehaviour
{
    public float delay = 15.0f;
    private Animator animator;

    public void Shoot()
    {
        print("Yooooo");
        animator = GetComponentInChildren<Animator>();
        Invoke("Shoot", delay);
        // Deal damage to player
        HealthManager.RemoveHealth();
        animator.SetBool("Shoot", true);
        Invoke("Shoot", delay);
    }

}
