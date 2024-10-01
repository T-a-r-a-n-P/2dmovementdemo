using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {
            if(Collision.gameObject.CompareTag("Player"))
    {
        Debug.Log("Collision detected with " + Collision.gameObject.name);
        Destroy(gameObject);
    }
    }
}
