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
}
