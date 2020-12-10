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
    {
        if (transform.childCount <= 0)
        {     
            playerNodeMovement.MoveToNextNode();
            enemyNodeMovement0.MoveToNextNode();
            enemyNodeMovement1.MoveToNextNode();
            enemyNodeMovement2.MoveToNextNode();
            enemyNodeMovement3.MoveToNextNode();
            enemyNodeMovement4.MoveToNextNode();
            enemyNodeMovement5.MoveToNextNode();

            shootAfterDelay0.Throw();
           



            Destroy(gameObject);
        }


    }

}
