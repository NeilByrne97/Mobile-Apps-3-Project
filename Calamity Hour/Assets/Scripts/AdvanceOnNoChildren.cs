using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement NodeMovement;
    public NodeMovement enemyNodeMovement;
    public Animator targetAnimator;

    int count = 2;

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
                //enemyNodeMovement = GameObject.FindGameObjectWithTag("Enemy").GetComponent<NodeMovement>();
            }
            if (targetAnimator == null)
            {
                print("Target animator is null");
                if (count == 2)
                {
                    print("Count is 2");
                    targetAnimator = GameObject.FindGameObjectWithTag("Enemy2").GetComponent<Animator>();

                   
                }

                else if (count == 3)
                {
                    targetAnimator = GameObject.FindGameObjectWithTag("Enemy3").GetComponent<Animator>();
                    print("Count is 3");
                    print("Yooooo");
                }
                print("Outside loop Count is " + count);
            }

            if (count == 3)
            {
                targetAnimator = GameObject.FindGameObjectWithTag("Enemy3").GetComponent<Animator>();
                print("Count is 3");
                print("Target != null");
            }

            count++;
            print("Count inc is " + count);

            NodeMovement.MoveToNextNode();
            //enemyNodeMovement.MoveToNextNode();
            targetAnimator.SetTrigger("Advance");
            Destroy(gameObject);


        }
    }
}
