using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI scoreText;      
    public TextMeshProUGUI totalScoreText;  

    private int score = 0;
    private int totalScore = 0;

    private const string TotalScoreKey = "TotalScore";

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        totalScore = PlayerPrefs.GetInt(TotalScoreKey, 0);
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    public void GameOver()
    {
        totalScore += score;
        PlayerPrefs.SetInt(TotalScoreKey, totalScore);
        PlayerPrefs.Save();
        UpdateUI();
    }

    public bool SpendScore(int amount)
    {
        if (totalScore >= amount)
        {
            totalScore -= amount;
            PlayerPrefs.SetInt(TotalScoreKey, totalScore);
            PlayerPrefs.Save();
            UpdateUI();
            return true;
        }

        return false;
    }

    public int GetTotalScore()
    {
        return totalScore;
    }

    void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "얻은 점수: " + score;

        if (totalScoreText != null)
            totalScoreText.text = "현재 보유한 재화: " + totalScore;
    }
}



