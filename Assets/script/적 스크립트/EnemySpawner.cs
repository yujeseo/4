using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnRange = 10f;
    public float difficultyInterval = 35f;

    private float spawnTimer = 0f;
    private float difficultyTimer = 0f;

    private int spawnCount = 1; 

    void Update()
    {
        
        if (ShopUI.Instance != null && ShopUI.Instance.IsShopOpen)
            return;

        
        spawnTimer += Time.deltaTime;
        difficultyTimer += Time.deltaTime;

        
        if (spawnTimer >= spawnInterval)
        {
            for (int i = 0; i < spawnCount; i++)
            {
                SpawnEnemy();
            }
            spawnTimer = 0f;
        }

        
        if (difficultyTimer >= difficultyInterval)
        {
            spawnCount++;
            difficultyTimer = 0f;
            Debug.Log($"스폰 수 증가! 이제 한 번에 {spawnCount}마리 생성");
        }
    }

    void SpawnEnemy()
    {
        Vector2 spawnPosition = (Vector2)transform.position + Random.insideUnitCircle * spawnRange;
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
