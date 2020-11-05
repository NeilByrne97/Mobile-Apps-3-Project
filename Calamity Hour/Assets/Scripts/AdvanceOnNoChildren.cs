using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    public NodeMovement playerNodeMovement;
    public NodeMovement enemyNodeMovement;

    public Animator enemyAdvance;

    void Update()
    {
        if (transform.childCount <= 0)
        {
            if (playerNodeMovement == null)
            {
                playerNodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
                enemyNodeMovement = GameObject.FindGameObjectWithTag("Enemy").GetComponent<NodeMovement>();

            }
            else
            {
                
            }
            playerNodeMovement.MoveToNextNode();
            enemyNodeMovement.MoveToNextNode();

            Destroy(gameObject);
            enemyAdvance.SetTrigger("Advance");
        }
    }
}
