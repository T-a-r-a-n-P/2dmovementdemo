using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public float maxHealth;
    public float currentHealth;

    public HUDmanager HUD;
    public GameObject gameover;

    void Start()
    {
        currentHealth = maxHealth;
        HUD.UpdateHealthBar(currentHealth);
        gameover.SetActive(false);
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        HUD.UpdateHealthBar(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameover.SetActive(true);
        Destroy(gameObject);
    }

}
