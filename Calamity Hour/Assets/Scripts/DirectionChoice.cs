using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChoice : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public int ChoiceMade;

    public NodeMovement NodeMovement;


    public void LeftOption()
    {
        ChoiceMade = 1;
        print("Left");
        if (NodeMovement == null)
        {
            NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
        }
        NodeMovement.TurnLeft();
    }

    public void RightOption()
    {
        ChoiceMade = 2;
        print("Right");
        if (NodeMovement == null)
        {
            NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
        }
        NodeMovement.TurnRight();
    }

    private void Update()
    {
        if(ChoiceMade >= 1)
        {
            Left.SetActive(false);
            Right.SetActive(false);
        }
    }


}
