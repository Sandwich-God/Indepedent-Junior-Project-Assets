using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint; // Sets the point of arrows spawning to the firePoint
    public GameObject arrowPrefab; // Links arrowPrefab to this script

    public float arrowForce = 15f; // Sets the arrow speed to 15.
    public float arrowAmount = 1;
    public float clicks = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // States that if the Input is left click it will fire an arrow.
        {
            Shoot();
        }
        if (Input.GetKeyDown("r"))
        {
            Reload();
        }
        void Shoot()
        {
            clicks += 1;
            if (arrowAmount == 1)
            {
                GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.right * arrowForce, ForceMode2D.Impulse);
                arrowAmount -= 1;
            }
            if (clicks == 2)
            {
                Reload();
            }
        }
        void Reload()
        {
            clicks = 0;
            if (arrowAmount < 1)
            {
                arrowAmount += 1;
                Debug.Log("test");
            }
        }
    }
}