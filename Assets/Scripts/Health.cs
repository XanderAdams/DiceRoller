using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 30;
    public int health;
    public int damage;
    DiceRoller sn;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        sn = gameObject.GetComponent<DiceRoller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            StandardDamage();
        }
        if (Input.GetKeyDown("c"))
        {
            CriticalDamage();
        }
    }

    //Reset health to maxHealth
    public void ResetHealth()
    {
        health = maxHealth;
        Debug.Log("Current health: " + health);
    }

    //Deal standard damage to health using RollDie
    public void StandardDamage()
    {
        damage = 0;
        
        damage = sn.RollDie(sn.sideCount);

        health = health-damage;

        if(health>0)
        {
            Debug.Log("Took " + damage + " damage!\n" + health + " HP remaining");
        }
        else
        {
            Debug.Log("You died! Starting over...");
            ResetHealth();
        }
    }

    //Deal critical damage to health using RollAdvantage
    public void CriticalDamage()
    {
        damage = 0;
       
        damage = sn.RollAdvantage(sn.sideCount);
        
        health = health-damage;
        
        if(health>0)
        {
            Debug.Log("Took " + damage + " damage!\n" + health + " HP remaining");
        }
        else
        {
            Debug.Log("You died! Starting over...");
            ResetHealth();
        }
    }
}
