using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement playerNodeMovement;

    void Update()
    {
        if (transform.childCount <= 0)
        {
            if (playerNodeMovement == null)
            {
                playerNodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
            }
            playerNodeMovement.MoveToNextNode();
            Destroy(gameObject);
        }
    }
}
