using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTemp : MonoBehaviour
{

    public GameObject EnemyT; // Makes the Enemy Sprite into an GameObject to be changed in script
    public float health = 2f; // Sets a variable where Enemies health is 2.

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision) // Detects the collision with other objects.
    {

        health -= 1; // Decrements the Enemies health.
        if (health == 0) // States that if the health is 0, it will destroy the gameObject/Enemy.
        {
 
            Destroy(gameObject); // Destroys gameObject/Enemy
        }
    }
}