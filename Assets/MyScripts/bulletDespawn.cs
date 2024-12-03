using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDespawn : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if (Collision.gameObject.CompareTag("Untagged"))
        {
            Destroy(gameObject);
        }
    }
}
