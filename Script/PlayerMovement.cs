using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Variable for players speed.

    public Rigidbody2D rb; // Variable for getting values for Movement.
    public Animator animator;

    Vector2 movement; // Contains the x and y value for movement.

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal"); // Inputs the value for x in movement.
        movement.y = Input.GetAxisRaw("Vertical"); // Inputs the value for y in movement.
        movement = new Vector2(movement.x, movement.y).normalized; // Makes the speed when moving in unison for two directions the same as one direction.

        animator.SetFloat("Horizontal", movement.x); // Changes the characters animation to left or right.
        animator.SetFloat("Vertical", movement.y); // Changes the characters animation to up or down.
        animator.SetFloat("Speed", movement.sqrMagnitude); // Updates the float value for the animator.
    }
    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // Moves the character in the direction needed.
    }
}