using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Health : MonoBehaviour
{
    public EndlessSpawner endlessSpawner;
    public int maxHealth;
    int currentHealth;
    int enemieskilled;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        endlessSpawner = GameObject.FindObjectOfType<EndlessSpawner> ();
    }
    void Update()
    {
        LowHealth();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
        Debug.Log("<b>Enemy</b> <i>took</i> " + damage + " <b><color=black>damage</color></b>");
    }
    public void LowHealth()
    {
        if (currentHealth < maxHealth/4)
        {
            Debug.LogWarning("<color=red><b>Enemy is on low health</b></color>");
        }
    }

    void Die()
    {
        endlessSpawner.enemiesAlive -= 1;
        enemieskilled += 1;

        Destroy(gameObject);
        Debug.Log("<color=red><b>Enemy has died in </b></color>" + Time.time + " seconds");
        
        if (endlessSpawner.enemiesAlive == 1)
        {
            Debug.Log(endlessSpawner.enemiesAlive + " enemy alive");
        }
        else
        {
            Debug.Log(endlessSpawner.enemiesAlive + " enemies alive");
        }
    }
}
