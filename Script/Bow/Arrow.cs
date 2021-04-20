using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject arrowPrefab; // Allows script to link the arrowPrefab and use it as a GameObject.

    void OnCollisionEnter2D(Collision2D collision) // Detects the collision with other objects.
    {
        Destroy(gameObject); // Destroys gameObject/arrowPrefab.
    }
}