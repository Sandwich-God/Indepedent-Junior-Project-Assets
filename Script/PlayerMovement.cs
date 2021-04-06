using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Variable for players speed.

    public Rigidbody2D rb; // Variable for getting values for Movement.
    public Camera cam; // Variable for getting values for mouse position.

    Vector2 movement; // Contains the x and y value for movement.
    Vector2 mousePos; // Contains the x and y value for mousePos.

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal"); // Inputs the value for x in movement.
        movement.y = Input.GetAxisRaw("Vertical"); //Inputs the value for y in movement.
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); //Gets the position of the mouse.
    }
    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // Moves the character in the direction needed.

        Vector2 lookDir = mousePos - rb.position; // Subtracts the two positions to get a new position.
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 270f; // Changes the characters facing direction to the mouse position.
        rb.rotation = angle; // Changes the rotation for character.
    }
}
// testing
