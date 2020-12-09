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
        if (currentNode == null)
        {
            throw new System.NullReferenceException("Don't worry about it");
        }
       
        currentNode = currentNode.nextNode;
        StartCoroutine(RotateToGoal(true));
        print("Current Node is " + currentNode);
        
    }

    public void CoverNode()
    {
        currentNode = currentNode.coverNode;
        print("Node is " + currentNode);
        StartCoroutine(RotateToGoal(true));
    }

    public void TurnLeft()
    {
        currentNode = currentNode.leftNode;
        print("Node is " + currentNode);
        StartCoroutine(RotateToGoal(true));
    }

    public void TurnRight()
    {
        currentNode = currentNode.rightNode;
        print("Node is " + currentNode);
        StartCoroutine(RotateToGoal(true));
    }

    IEnumerator RotateToGoal(bool initialRotation)
    {
        print("Rotate");
        Quaternion goalRotation;
        if (initialRotation)
        {
            goalRotation = Quaternion.LookRotation(currentNode.transform.position - transform.position);
        }
        else
        {   // Player rotation is equal to node rotation
            goalRotation = currentNode.transform.rotation;
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
            // To ensure you have arrived at the currentNode
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
