using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Node currentNode;
    public float movementSpeed = 1.0f;
    public float rotationSpeed = 45.0f;

    private Node nextNode;

    public void MoveToNextNode()
    {
        nextNode = currentNode.nextNode;
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
    }


}
