using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform target;
    public bool inCombat = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Attack entered");
    }

    void OnTriggerStay2D(Collider2D col)
    {
        //Debug.Log("Attack stay");
        Vector3 Look = transform.InverseTransformPoint(target.transform.position);
        float Angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg - 90;

        transform.Rotate(0, 0, Angle);
        inCombat = true;
    }

    void OnTriggerExit2D()
    {
        inCombat = false;
    }
}
