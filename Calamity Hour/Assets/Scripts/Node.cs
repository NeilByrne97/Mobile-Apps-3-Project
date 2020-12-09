using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node nextNode;
    public Node leftNode;
    public Node rightNode;
    public Node coverNode;

    private void OnDrawGizmos()
    {
        if(nextNode != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, nextNode.transform.position);
           
        }

    }


}
