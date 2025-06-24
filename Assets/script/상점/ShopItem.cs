using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public enum ShopItemType
{
    Heal,
    DamageUp
}


public class ShopItem : MonoBehaviour
{
    public ShopItemType itemType;
    public int value;  // ȸ���� or ���ݷ� ������
    public int price;  // ������ ���� (���� �������� ������)

    public void TryBuy()
    {
        if (ScoreManager.Instance.SpendScore(price))
        {
            ApplyEffect();
        }
        else
        {
            Debug.Log("������ �����մϴ�!");
        }
    }

    void ApplyEffect()
    {
        GameObject player = GameObject.FindWithTag("Player");

        switch (itemType)
        {
            case ShopItemType.Heal:
                var health = player.GetComponent<PlayerHealth>();
                if (health != null) health.Heal(value);
                break;

            case ShopItemType.DamageUp:
                var weapon = player.GetComponentInChildren<WeaponShoot>();
                if (weapon != null) weapon.UpgradeDamage(value);
                break;
        }
    }
}