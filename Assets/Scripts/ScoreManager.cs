using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Text objects to display the score and high schore
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI endScoreText;

    // Variables to store the current sore and high score 
    private float score;
    private float highScore;

    void Start()
    {
        // Load the high score from PlayerPrefs when the game starts
        // PlayerPrefs allows saving and retrieving player preferences (scores) 
        // between game sessions
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        // Display the high score 
        highScoreText.text = ((int)highScore).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player object exists in the scene
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            // Increment the score each frame that the player is alive 
            score += 1 * Time.deltaTime;
            // Display the current score
            scoreText.text = ((int)score).ToString();
        }

        else
        {
            // Display the final score when the player is dead
            endScoreText.text = ((int)score).ToString();

            // Check if the current score is greater than the high score 
            if (score > highScore)
            {
                // Update the high score 
                highScore = score;
                // Display the new high score 
                highScoreText.text = ((int)highScore).ToString();

                // Save the new high score to PlayerPrefs for future sessions
                PlayerPrefs.SetFloat("HighScore", highScore);
                PlayerPrefs.Save();
            }
        }
    }
}
