using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection_on_click : MonoBehaviour
{
    GameObject[] UnitsToDisable ;
    public bool selected = false;

    void UnselectUnits()
    {
        UnitsToDisable = GameObject.FindGameObjectsWithTag("PlayerControlledUnit");

        foreach (GameObject.FindGameObjectWithTag("PlayerControlledUnit") in UnitsToDisable)
        {

            selected = false;

        }


    }





    void OnMouseDown()
    {
        

     
        if (selected == false)
        {
            UnselectUnits();

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
