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
        // ����Ƽ �����Ϳ��� �׽�Ʈ�� ���� �����͸� ����� ����ó�� ����
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
