using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Node nextNode;
    public float movementSpeed = 1.0f;
    public float rotationSpeed = 45.0f;

    void Start()
    {
        nextNode = nextNode.nextNode;
    }


    public void MoveToNextNode()
    {
        StartCoroutine(RotateToGoal(true));
    }

    IEnumerator RotateToGoal(bool initialRotation)
    {
        Quaternion goalRotation = Quaternion.LookRotation(nextNode.transform.position - transform.position);

        while (true)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, goalRotation, rotationSpeed * Time.deltaTime);

            if (transform.rotation != goalRotation)
            {
                yield return null;
            }
            else
            {
                break;
            }
        }
        if (initialRotation)
        {
            StartCoroutine(MoveToGoal());
        }
    }

    IEnumerator MoveToGoal()
    {
        while (true)
        {
            transform.position += transform.forward*movementSpeed*Time.deltaTime;
      
            if (Vector3.Dot(transform.forward, nextNode.transform.position - transform.position) <= 0)
            {
                transform.position = nextNode.transform.position;
                break;
            }
            yield return null;
        }
        nextNode = nextNode.nextNode;
        StartCoroutine(RotateToGoal(false));
    }

}
