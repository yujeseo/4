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

        // ���� �Ͻ����� (���û���)
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // �ð� �ǵ�����
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // ���� �� �����
    }

    public void ExitToMain()
    {
        Time.timeScale = 1f; // �ð� �ǵ�����
        SceneManager.LoadScene("MainMenu"); // ���� �� �̸��� �°� ����
    }
}