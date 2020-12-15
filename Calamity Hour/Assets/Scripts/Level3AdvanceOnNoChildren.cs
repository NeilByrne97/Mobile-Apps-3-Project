using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement playerNodeMovement;
    public NodeMovement enemyNodeMovement0;
    public NodeMovement enemyNodeMovement1;
    public NodeMovement enemyNodeMovement2;
    public NodeMovement enemyNodeMovement3;
    public NodeMovement enemyNodeMovement4;
    public NodeMovement enemyNodeMovement5;

    void Update()
    {   // If all enemies in stage are dead
        if (transform.childCount <= 0)
        {       // Find the next stage of enemeis 
            if (playerNodeMovement == null)
            {
                playerNodeMovement.GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement0 == null)
            {
                enemyNodeMovement0.GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement1 == null)
            {
                enemyNodeMovement1.GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement2 == null)
            {
                enemyNodeMovement2.GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement3 == null)
            {
                enemyNodeMovement3.GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement4 == null)
            {
                enemyNodeMovement4.GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement5 == null)
            {
                enemyNodeMovement5.GetComponent<NodeMovement>();
            }
            // Move them into position
            playerNodeMovement.MoveToNextNode();
            enemyNodeMovement0.MoveToNextNode();
            enemyNodeMovement1.MoveToNextNode();
            enemyNodeMovement2.MoveToNextNode();
            enemyNodeMovement3.MoveToNextNode();
            enemyNodeMovement4.MoveToNextNode();
            enemyNodeMovement5.MoveToNextNode();

            Destroy(gameObject);
        }


    }

}
