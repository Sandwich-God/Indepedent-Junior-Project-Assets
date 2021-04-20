using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public float moveSpeed = 5f; // Variable for players speed.

    public Rigidbody2D rb; // Variable for getting values for Movement.
    public Camera cam; // Variable for getting values for mouse position.

    Vector2 movement; // Contains the x and y value for movement.

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal"); // Inputs the value for x in movement.
        movement.y = Input.GetAxisRaw("Vertical"); // Inputs the value for y in movement.
        movement = new Vector2(movement.x, movement.y).normalized; // Makes the speed when moving in unison for two directions the same as one direction.
    }
    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // Moves the character in the direction needed.

        //Vector2 lookDir = mousePos - rb.position; // Subtracts the two positions to get a new position.
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position; //Gets the position of the mouse.
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg; // Changes the characters facing direction to the mouse position.
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward); // Changes the rotation for character.
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, moveSpeed * Time.fixedDeltaTime);
    }
}