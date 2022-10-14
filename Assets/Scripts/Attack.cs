using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Attack entered");
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("Attack stay");
    }
}
