using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    DiceRoller sn;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        sn = gameObject.GetComponent<DiceRoller>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //Reset health to maxHealth
    public void ResetHealth()
    {
        currentHealth = maxHealth;
        Debug.Log("Current health: " + currentHealth);
    }
}
