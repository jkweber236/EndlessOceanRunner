using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Speed of the player movement
    public float playerSpeed;

    // Rigidbody component for object interactions
    private Rigidbody2D rb;

    // Direction of player movement 
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        // Getting the Rigidbody componenet attached to the player GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input for vertical movement (up and down arrow keys)
        float directionY = Input.GetAxisRaw("Vertical");

        // Set the player's movement direction along the vertical axis with a constant speed 
        playerDirection = new Vector2(0, directionY).normalized;
    }

    // Method to calculate and update player movement
    void FixedUpdate()
    {
        // Set the player's velocity using the Rigidbody component
        // This will change the vertical movement of the player
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
