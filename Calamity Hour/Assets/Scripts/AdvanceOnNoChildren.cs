﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement playerNodeMovement;
    public NodeMovement enemyNodeMovement;


    void Update()
    {
        if (transform.childCount <= 0)
        {
            if (playerNodeMovement == null)
            {
                playerNodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
            }
            if(enemyNodeMovement == null)
            {
                enemyNodeMovement = GameObject.FindGameObjectWithTag("Enemy").GetComponent<NodeMovement>();
            }


            playerNodeMovement.MoveToNextNode();
            enemyNodeMovement.MoveToNextNode();

            Destroy(gameObject);
            
        }
    }
}
