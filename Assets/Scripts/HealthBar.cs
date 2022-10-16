using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image HealthBarImage;
    public float currentHealth;
    private float MaxHealth = 100f;
    AgentMovement Player;

    private void Start()
    {
        HealthBarImage = GetComponent<Image>();
        Player = FindObjectOfType<AgentMovement>();
    }
    private void Update()
    {
        currentHealth=Player.Health;
        HealthBarImage.fillAmount = currentHealth / MaxHealth;
    }
}
