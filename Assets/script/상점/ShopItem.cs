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
    public int value;  // 회복량 or 공격력 증가량
    public int price;  // 아이템 가격 (누적 점수에서 차감됨)

    public void TryBuy()
    {
        if (ScoreManager.Instance.SpendScore(price))
        {
            ApplyEffect();
        }
        else
        {
            Debug.Log("점수가 부족합니다!");
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