using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint; // Sets the point of arrows spawning to the firePoint
    public GameObject arrowPrefab; // Links arrowPrefab to this script

    public float arrowForce = 15f; // Sets the arrow speed to 15.
    public float arrowAmount = 1; // Sets the arrow amount to be 1.
    public float clicks = 0; // Sets the clicks to 0.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // States that if the Input is left click it will fire an arrow.
        {
            Shoot(); // Calls to the Shoot() function.
        }
        if (Input.GetKeyDown("r")) // States that if the Input is r it will reload the arrow.
        {
            Reload(); // Calls to the Reload() function.
        }
        void Shoot() // The Shoot function main purpose is to fire arrows.
        {
            clicks += 1; // Increments clicks.
            if (arrowAmount == 1) // States that if arrowAmount equals 1 it will fire an arrow.
            {
                GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation); // Will create an arrow with arrowPrefab at the firePoint.
                Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>(); // Applies arrow to rb.
                rb.AddForce(firePoint.right * arrowForce, ForceMode2D.Impulse); // Adds force to the arrow for movement.
                arrowAmount -= 1; // Decrements the arrowAmount.
            }
            if (clicks == 2) // States that if clicks equal 2 it will reload.
            {
                Reload(); // Calls to the Reload() function.
            }
        }
        void Reload() // The Reload function main purpose is to reload the bow.
        {
            clicks = 0; // Sets click amount to 0.
            if (arrowAmount < 1) // States that if arrowAmount is less than 1 it it will add an arrow.
            {
                arrowAmount += 1; // Increments arrowAmount.
            }
        }
    }
}