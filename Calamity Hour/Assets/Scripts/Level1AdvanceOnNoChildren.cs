using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement NodeMovement;
    //public NodeMovement enemyNodeMovement;
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
            NodeMovement.MoveToNextNode();
            Destroy(gameObject);
        }
    }
}
