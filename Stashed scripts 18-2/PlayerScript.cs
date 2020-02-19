using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : BaseAI //script will inherit from BaseAi script
{
    public float maxHealth = 100;
    public float currentHealth;
    public float defense;
    public float speed;
    public float damage;
    
    //modes the AI can switch between, with values represented as percentages
    public Vector3 Defensive = new Vector3(.6f,.2f,.2f);
    public Vector3 Offensive = new Vector3(.2f,.2f,.6f);
    public Vector3 Retreat = new Vector3(.2f,.6f,.2f);

    public HealthScript healthBar;
    public StatControl statControl;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            TakeDamage(20);
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetDefensive();
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            SetOffesive();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SetRetreat();
        }
    }

    public void SetDefensive()
    {
        Stats.SetNewMode(Defensive);
    }

    public void SetOffesive()
    {
        Stats.SetNewMode(Offensive);
    }

    public void SetRetreat()
    {
        Stats.SetNewMode(Retreat);
    }

    void TakeDamage (int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
