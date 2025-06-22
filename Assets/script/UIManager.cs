using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Slider healthSlider; // �����̴� ����

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void SetMaxHealth(int maxHealth)
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;
    }

    public void UpdateHealth(int currentHealth)
    {
        healthSlider.value = currentHealth;
    }
}
