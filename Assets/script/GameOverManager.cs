using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager Instance;

    public GameObject gameOverUI;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void ShowGameOver()
    {
        gameOverUI.SetActive(true);

        // 게임 일시정지 (선택사항)
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // 시간 되돌리기
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 현재 씬 재시작
    }

    public void ExitToMain()
    {
        Time.timeScale = 1f; // 시간 되돌리기
        SceneManager.LoadScene("MainMenu"); // 메인 씬 이름에 맞게 수정
    }
}