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
        movement.y = Input.GetAxisRaw("Vertical"); //Inputs the value for y in movement.

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // Moves the character in the direction needed.
    }
}
// testing
