using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject shopPrefab;      
    public Transform player;          
    public float spawnInterval = 120f;  
    public float spawnDistance = 3f;    

    private float timer;

    void Update()
    {
        if (ShopUI.Instance != null && ShopUI.Instance.IsShopOpen)
            return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnShop();
            timer = 0f;
        }
    }

    void SpawnShop()
    {
        Vector2 offset = Random.insideUnitCircle.normalized * spawnDistance;
        Vector3 spawnPosition = player.position + new Vector3(offset.x, offset.y, 0f);

        GameObject shop = Instantiate(shopPrefab, spawnPosition, Quaternion.identity);

        Destroy(shop, 10f);
    }
}
