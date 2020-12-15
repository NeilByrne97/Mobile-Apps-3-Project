using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement NodeMovement;
    void Update()
    {
        if (transform.childCount <= 0)
        {
            print("Update");
            if (NodeMovement == null)
            {   // Find the Players node movment component
                NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
            }
            NodeMovement.MoveToNextNode();
            Destroy(gameObject);
        }
    }
}
