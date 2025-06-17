using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    private int highScore;

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    public void GameOver()
    {
        // 최고 점수 갱신
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        UpdateHighScoreUI();
    }



    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "현재 점수: " + score.ToString();
    }

    void UpdateHighScoreUI()
    {
        if (highScoreText != null)
            highScoreText.text = "High Score: " + highScore.ToString();
    }




}

