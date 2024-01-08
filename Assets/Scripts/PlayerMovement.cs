using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the move speed as needed
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        // Handle mouse input
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        // Handle keyboard input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalize the movement vector to ensure consistent speed in all directions
        movement.Normalize();
    }

    void FixedUpdate()
    {
        // Move the player using keyboard input
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        // Look at the mouse position
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.SetRotation(angle);
    }
}