using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBotton : MonoBehaviour
{
    public ShopItem healItem;
    public ShopItem damageItem;

    public void OnBuyHeal()
    {
        healItem.TryBuy();  // 회복
    }

    public void OnBuyDamage()
    {
        damageItem.TryBuy();  // 데미지 업
    }
}