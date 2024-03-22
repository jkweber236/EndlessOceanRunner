using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI endScoreText;
    private float score;
    private float highScore;

    void Start()
    {
        // Load the high score from PlayerPrefs
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        highScoreText.text = ((int)highScore).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }

        else
        {
            endScoreText.text = ((int)score).ToString();

            if (score > highScore)
            {
                highScore = score;
                highScoreText.text = ((int)highScore).ToString();

                // Save the new high score to PlayerPrefs
                PlayerPrefs.SetFloat("HighScore", highScore);
                PlayerPrefs.Save();
            }
        }
    }
}
