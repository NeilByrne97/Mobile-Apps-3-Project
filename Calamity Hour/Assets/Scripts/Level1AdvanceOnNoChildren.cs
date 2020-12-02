using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement NodeMovement;
    public NodeMovement enemyNodeMovement;
    public NodeMovement enemyNodeMovement1;
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

            if (enemyNodeMovement == null)
            {
                print("Enemy");
                enemyNodeMovement = GameObject.FindGameObjectWithTag("Enemy").GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement1 == null)
            {
                print("Enemy1");
                enemyNodeMovement1 = GameObject.FindGameObjectWithTag("Enemy2").GetComponent<NodeMovement>();
            }

            NodeMovement.MoveToNextNode();
            enemyNodeMovement.MoveToNextNode();
            enemyNodeMovement1.MoveToNextNode();

            Destroy(gameObject);
        }
    }

}
