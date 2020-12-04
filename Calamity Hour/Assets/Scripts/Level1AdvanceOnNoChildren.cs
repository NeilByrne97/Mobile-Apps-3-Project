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

    public ShootAfterDelay shootAfterDelay0;
    public ShootAfterDelay shootAfterDelay1;
    public ShootAfterDelay shootAfterDelay2;
    public ShootAfterDelay shootAfterDelay3;
    public ShootAfterDelay shootAfterDelay4;


    void Update()
    {
        if (transform.childCount <= 0)
        {
            print("Update");
            if (playerNodeMovement == null)
            {
                print("Player");
                playerNodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement0 == null)
            {
                print("enemy0");
                enemyNodeMovement0.GetComponent<NodeMovement>();
            }

            if (enemyNodeMovement1 == null)
            {
                print("enemy1");
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
                print("Enemy4");
                enemyNodeMovement4.GetComponent<NodeMovement>();

            }

            playerNodeMovement.MoveToNextNode();
            enemyNodeMovement0.MoveToNextNode();
            enemyNodeMovement1.MoveToNextNode();
            enemyNodeMovement2.MoveToNextNode();
            enemyNodeMovement3.MoveToNextNode();

         /*   if (shootAfterDelay0 == null)
            {
                shootAfterDelay0.GetComponent<ShootAfterDelay>();
                shootAfterDelay0.Shoot();
            }

            if (shootAfterDelay1 == null)
            {
                shootAfterDelay1.GetComponent<ShootAfterDelay>();
                shootAfterDelay1.Shoot();
            }

            if (shootAfterDelay2 == null)
            {
                shootAfterDelay2.GetComponent<ShootAfterDelay>();
                shootAfterDelay2.Shoot();
            }

            if (shootAfterDelay3 == null)
            {
                shootAfterDelay3.GetComponent<ShootAfterDelay>();
                shootAfterDelay3.Shoot();
            }

            if (shootAfterDelay4 == null)
            {
                shootAfterDelay4.GetComponent<ShootAfterDelay>();
                shootAfterDelay4.Shoot();
            }       
            */
            Destroy(gameObject);
        }


    }

}
