using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection_on_click : MonoBehaviour
{

    public bool selected = false;


    void OnMouseDown()
    {
        

        /*Debug.Log("selected");  */ 
        if (selected == false)
        {
            selected = true;
            Debug.Log("on");
        }
        else if (selected == true)
        {
            selected = false;
            Debug.Log("off");
        }

    }


}
