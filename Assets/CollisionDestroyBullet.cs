using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroyBullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Collision detected with " + Collision.gameObject.name);
            Destroy(gameObject);
        }
    }
}
