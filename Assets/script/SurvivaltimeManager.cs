using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SurvivaltimeManager : MonoBehaviour
{
    public TextMeshProUGUI survivalText;
    private float survivalTime;

    void Update()
    {
        survivalTime += Time.deltaTime;
        int timeInt = Mathf.FloorToInt(survivalTime);
        survivalText.text = $"생존 시간: {timeInt}초";
    }
}
