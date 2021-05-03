using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100; // Sets the maxHealth variable to 100.
    public int currentHealth; // A variable that is changed to show the player's current health.
    public HealthBar healthBar; // Calls to the HealthBar script and uses healthBar to use functions from that script.

    public object EnemyT { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // currentHealth defines maxHealth.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // If space is pressed, player will take damage.
        {
            PlayerTakeDamage(20); // Takes 20 damage.
        }
        
    }
    public void PlayerTakeDamage(int damage) // Function named PlayerTakeDamage where you can return the variable damage.
    {
        currentHealth -= damage; // Subtracts currentHealth damage.
        healthBar.SetHealth(currentHealth); // Sets the healthBar on the UI.
    }
}
