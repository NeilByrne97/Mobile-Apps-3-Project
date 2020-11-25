using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChoice : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public int ChoiceMade;

    public void LeftOption()
    {
        print("Left");
        ChoiceMade = 1;
    }

    public void RightOption()
    {
        print("Right");
        ChoiceMade = 2;
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
