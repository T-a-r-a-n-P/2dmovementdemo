using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collision detected with " + Collision.gameObject.name);
            transform.position = new Vector3(0,0,0);
        }
    }
}
