using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTutorial : MonoBehaviour
{
    int damage = 5;
    DiceRoller diceRoller;
    PlayerData health;
    
    // Start is called before the first frame update
    void Start()
    {
        diceRoller = gameObject.GetComponent<DiceRoller>();
        health = gameObject.GetComponent<PlayerData>();
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

    void Damage(int damage)
    {
        health.currentHealth -= damage;
    }

     public void StandardDamage()
    {
        Damage(diceRoller.RollDie(diceRoller.sideCount));
        if(health.currentHealth>0)
        {
            Debug.Log("Took " + damage + " damage!\n" + health.currentHealth + " HP remaining");
        }
        else
        {
            Debug.Log("You died! Starting over...");
            health.ResetHealth();
        }
    }

    //Deal critical damage to health using RollCritical
    public void CriticalDamage()
    {       
        damage = diceRoller.RollCritical(diceRoller.sideCount);
        Damage(damage);
        if(health.currentHealth>0)
        {
            Debug.Log("Critical hit! Took " + damage + " damage!\n" + health.currentHealth + " HP remaining");
        }
        else
        {
            Debug.Log("You died! Starting over...");
            health.ResetHealth();
        }
    }
}
