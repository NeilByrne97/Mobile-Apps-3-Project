using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    private Animator targetAnimator;

    private void Start()
    {
   
    }


    void Update()
    {

        if (transform.childCount <= 0)
        {
            if (targetAnimator == null)
            {
                targetAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

            }
            targetAnimator.SetTrigger("Advance");
        }
    }
}
