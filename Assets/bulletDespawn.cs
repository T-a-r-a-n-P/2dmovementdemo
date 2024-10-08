using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDespawn : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Collision)
    {
    
        Destroy(gameObject);
    }
}
