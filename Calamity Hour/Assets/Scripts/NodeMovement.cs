using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Node currentNode;
    public float movementSpeed = 1.0f;
    public float rotationSpeed = 45.0f;

    public void MoveToNextNode()
    {
        currentNode = currentNode.nextNode;
        StartCoroutine(RotateToGoal(true));
    }

    IEnumerator RotateToGoal(bool initialRotation)
    {
        Quaternion goalRotation;
        if (initialRotation)
        {
            goalRotation = Quaternion.LookRotation(currentNode.transform.position - transform.position);
        }
        else
        {
            goalRotation = currentNode.transform.rotation;
            print("Rotating on node");
        }

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
      
            if (Vector3.Dot(transform.forward, currentNode.transform.position - transform.position) <= 0)
            {
                transform.position = currentNode.transform.position;
                break;
            }
            yield return null;
        }
        StartCoroutine(RotateToGoal(false));
    }

}
