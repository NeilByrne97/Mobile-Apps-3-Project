using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChoice : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public GameObject Cover;
    public int ChoiceMade;

    public NodeMovement NodeMovement;

    // Depeding on the button , call the associated method 
    public void CoverReload()
    {
        if (NodeMovement == null)
        {
            NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
        }
        NodeMovement.CoverNode();
    }
    
    public void LeftOption()
    {
        ChoiceMade = 1;
        if (NodeMovement == null)
        {
            NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
        }
        NodeMovement.TurnLeft();
    }

    public void RightOption()
    {
        ChoiceMade = 2;
        if (NodeMovement == null)
        {
            NodeMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<NodeMovement>();
        }
        NodeMovement.TurnRight();
    }

    private void Update()
    {   // Once a choice is made, turn off the prompt 
        if(ChoiceMade >= 1)
        {
            Left.SetActive(false);
            Right.SetActive(false);
        }
    }


}
