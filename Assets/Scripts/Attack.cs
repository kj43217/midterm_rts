using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform target;
    public bool inCombat = false;

    public SpriteRenderer spriteRenderer;//----------------------------- animation change when attack
    public Sprite newSprite;
    public Sprite[] spriteArray;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (inCombat)
        {
            ChangeSprite();
        }
    }

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
        ChangeSprite();
    }
    void ChangeSprite()
    {
        spriteRenderer.sprite = spriteArray[0];
    }
}
