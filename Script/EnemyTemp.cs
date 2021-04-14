using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTemp : MonoBehaviour
{
    public GameObject EnemyT;
    public float health = 2f;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        health -= 1;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
