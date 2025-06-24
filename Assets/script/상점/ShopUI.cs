using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    public static ShopUI Instance;

    public GameObject shopUI;
    public bool IsShopOpen => shopUI.activeSelf;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void OpenShop()
    {
        shopUI.SetActive(true);
    }

    public void CloseShop()
    {
        shopUI.SetActive(false);
    }
}
