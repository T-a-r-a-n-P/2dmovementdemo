using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
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
        Destroy(gameObject);
        Debug.Log("<color=red><b>Enemy has died in </b></color>" + Time.time + " seconds");
    }
}
