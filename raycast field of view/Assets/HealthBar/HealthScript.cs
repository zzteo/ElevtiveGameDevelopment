using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public PlayerScript playerScript;
    public GameObject player;

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(float health)
    {
        slider.value = health;
    }
    public void Update()
    {
        if(playerScript.currentHealth == 0)
        {
           // Destroy(this.gameObject);
            Debug.Log("Player dead");
            Destroy(player);
        }
    }
}
