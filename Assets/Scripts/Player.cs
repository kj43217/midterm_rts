using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    public HealthBar healthBar;
    public Attack leaderScr;
    
    bool takingDamage;

    
    // Start is called before the first frame update
    void Start()
    {
        
        
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        takingDamage = leaderScr.in_Combat;
        Debug.Log(leaderScr.in_Combat);
        
        if(leaderScr.in_Combat)
        {
            TakeDamage(10f);
        }
    }

    void TakeDamage(float damage)
    {
        
            Debug.Log("Dealing Damage");
            currentHealth -= damage * Time.deltaTime;
        healthBar.setHealth(currentHealth);
        

    }
}
