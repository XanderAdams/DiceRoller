using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 30;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Reset health to maxHealth
    public void ResetHealth()
    {
        health = maxHealth;
        Debug.Log("Current health: " + health);
    }

    //Deal damage to health
    public void Damage(int damage)
    {
        
    }
}
