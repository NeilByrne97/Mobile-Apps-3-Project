using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement NodeMovement;
    public NodeMovement enemyNodeMovement0;
    public NodeMovement enemyNodeMovement1;
    public NodeMovement enemyNodeMovement2;
    public NodeMovement enemyNodeMovement3;
    public NodeMovement enemyNodeMovement4;
    //public Animator targetAnimator;

    [SerializeField] int count = 2;

    void Update()
    {
        if (transform.childCount <= 0)
        {
            print("Update");
            if (NodeMovement == null)
            {
                NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();

            }

            if (enemyNodeMovement0 == null)
            {
                print("Enemy0");
                // enemyNodeMovement0 = GameObject.FindGameObjectWithTag("Enemy0").GetComponent<NodeMovement>();
                enemyNodeMovement0.GetComponent<NodeMovement>();


            }

            if (enemyNodeMovement1 == null)
            {
                print("Enemy1");
                enemyNodeMovement1.GetComponent<NodeMovement>();
                //enemyNodeMovement1.MoveToNextNode();

            }

               if (enemyNodeMovement2 == null)
               {
                   print("Enemy2");
                   enemyNodeMovement2.GetComponent<NodeMovement>();
               }

               if (enemyNodeMovement3 == null)
               {
                   print("Enemy3");
                   enemyNodeMovement3.GetComponent<NodeMovement>();
               }
/*

               if (enemyNodeMovement4 == null)
               {
                   print("Enemy4");
                   enemyNodeMovement4.GetComponent<NodeMovement>();

               }
   */

            NodeMovement.MoveToNextNode();
            enemyNodeMovement0.MoveToNextNode();
            enemyNodeMovement1.MoveToNextNode();
            enemyNodeMovement2.MoveToNextNode();
            enemyNodeMovement3.MoveToNextNode();


            Destroy(gameObject);
        }


    }

}
