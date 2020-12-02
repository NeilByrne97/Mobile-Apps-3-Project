using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement NodeMovement;
    public NodeMovement enemyNodeMovement;
    public Animator targetAnimator;

    void Update()
    {
        if (transform.childCount <= 0)
        {
            print("Update");
            if (NodeMovement == null)
            {
                NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
            }

            if(enemyNodeMovement == null)
            {
                enemyNodeMovement = GameObject.FindGameObjectWithTag("Enemy").GetComponent<NodeMovement>();
            }
            /*if (targetAnimator == null)
            {
                targetAnimator = GameObject.FindGameObjectWithTag("Enemy2").GetComponent<Animator>();
            }
            if (targetAnimator == null)
            {
                targetAnimator = GameObject.FindGameObjectWithTag("Enemy3").GetComponent<Animator>();
            }
            

    */
            NodeMovement.MoveToNextNode();
            enemyNodeMovement.MoveToNextNode();
            //targetAnimator.SetTrigger("Advance");
            Destroy(gameObject);


        }
    }
}
