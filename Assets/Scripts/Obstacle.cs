using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // Find the player object in the scene
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Destroys obstacles upon collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the obstacle has collided with the border of the game area
        if (collision.tag == "Border")
        {
            // Destroys the obstacle game object when it has left the screen
            Destroy(this.gameObject);
        }

        // Check if the obstacle has collided  with the player 
        else if (collision.tag == "Player")
        {
            // Destroy the player game object once it has collided with an obstacle
            Destroy(player.gameObject);
        }
    
    }
}
