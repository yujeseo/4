using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBotton : MonoBehaviour
{
    public ShopItem healItem;
    public ShopItem damageItem;

    public void OnBuyHeal()
    {
        healItem.TryBuy();  // ȸ��
    }

    public void OnBuyDamage()
    {
        damageItem.TryBuy();  // ������ ��
    }
}