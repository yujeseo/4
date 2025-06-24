using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botton : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Ingame");
    }

    public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        // 유니티 에디터에서 테스트할 때는 에디터를 멈춰야 종료처럼 보임
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
