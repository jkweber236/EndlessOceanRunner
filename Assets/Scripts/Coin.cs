using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        // Find the player object in the scene
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Destroy coin upon collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision is with the border of the game area
        if (collision.CompareTag("Border"))
        {
            // Destroy the coin game object when it has left the screen
            Destroy(gameObject);
        }
        // Check if the collision is with the player 
        else if (collision.CompareTag("Player"))
        {
            // Destroy the coin once it has collided with the player
            Destroy(gameObject);
        }
    }
}
