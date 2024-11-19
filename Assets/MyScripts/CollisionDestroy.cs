using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {
        Debug.Log("Collision detected with " + Collision.gameObject.name);
                
        if(Collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
        }

         if(Collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Collision detected with " + Collision.gameObject.name);
            Destroy(gameObject);
        }
    }
}
