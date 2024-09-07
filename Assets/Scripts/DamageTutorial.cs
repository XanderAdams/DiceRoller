using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTutorial : MonoBehaviour
{
    int health = 1000;
    int damage = 5;
    int str = 3;
    DiceRoller sn;
    
    // Start is called before the first frame update
    void Start()
    {
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

    void Damage(int damage)
    {
        health -= damage;

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

     public void StandardDamage()
    {
        Damage(sn.RollDie(sn.sideCount));
        
    }

    //Deal critical damage to health using RollAdvantage
    public void CriticalDamage()
    {       
        damage = sn.RollAdvantage(sn.sideCount);
        
        Damage(damage);
        
    }

    public void BasicAttack()
    {
        Damage(damage);
    }

    public void GoodAttack()
    {
        Damage(damage+str);
    }

    public void ResetHealth()
    {
        health = 1000;
        Debug.Log("Current health: " + health);
    }
}
