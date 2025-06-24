using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 50;
    private int currentHealth;

    public int scoreReward = 100;

    public AudioClip deathSound;         
    private AudioSource audioSource;

    void Start()
    {
        currentHealth = maxHealth;

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        Debug.Log("Àû Ã¼·Â: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();

            if (deathSound != null)
            {
                AudioSource.PlayClipAtPoint(deathSound, transform.position);
            }

            ScoreManager.Instance.AddScore(scoreReward);
            Destroy(gameObject);
        }
    }

    void Die()
    {
        ScoreManager.Instance.AddScore(scoreReward);
        Destroy(gameObject);
    }
}
