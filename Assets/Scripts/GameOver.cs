using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
        // Check if the player object no longer exists in the scene
        if (GameObject.FindGameObjectWithTag("Player") == null) 
        {
            // Activate the game over panel
            gameOverPanel.SetActive(true);
        }
    }

    // Method to restart the game
    public void Restart()
    {
        // Load the current scene again to restart the game 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
