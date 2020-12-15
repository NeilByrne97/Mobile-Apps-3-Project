using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement playerNodeMovement;
    public NodeMovement enemyNodeMovement0;
    public NodeMovement enemyNodeMovement1;
    public NodeMovement enemyNodeMovement2;
    public NodeMovement enemyNodeMovement3;
    public NodeMovement enemyNodeMovement4;
    public NodeMovement enemyNodeMovement5;

    public ThrowAfterDelay shootAfterDelay0;
    public ThrowAfterDelay shootAfterDelay1;
    public ThrowAfterDelay shootAfterDelay2;
    public ThrowAfterDelay shootAfterDelay3;
    public ThrowAfterDelay shootAfterDelay4;
    public ThrowAfterDelay shootAfterDelay5;

    void Update()
    {   // If all the enemies are dead
        if (transform.childCount <= 0)
        {   // Find enmies in next stage 
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
            // Start them moving into position
            playerNodeMovement.MoveToNextNode();
            enemyNodeMovement0.MoveToNextNode();
            enemyNodeMovement1.MoveToNextNode();
            enemyNodeMovement2.MoveToNextNode();
            enemyNodeMovement3.MoveToNextNode();
            enemyNodeMovement4.MoveToNextNode();
            enemyNodeMovement5.MoveToNextNode();
            
            // Invoke the delay for when they throw projectiles
            shootAfterDelay0.Throw();
            shootAfterDelay1.Throw();
            shootAfterDelay2.Throw();
            shootAfterDelay3.Throw();
            shootAfterDelay4.Throw();
            shootAfterDelay5.Throw();


            Destroy(gameObject);
        }


    }

}
