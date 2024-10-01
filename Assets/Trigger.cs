using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject doorWall;
    void OnTriggerEnter2D(Collider2D Collider)
    {
            if(Collider.gameObject.CompareTag("Player"))
    {
        Debug.Log("Trigger detected with " + Collider.gameObject.name);
        doorWall.SetActive(false);
    }
    }
    void OnTriggerExit2D(Collider2D Collider)
    {
            if(Collider.gameObject.CompareTag("Player"))
    {
        Debug.Log("Trigger ended with " + Collider.gameObject.name);
        doorWall.SetActive(true);
    }
    }
}
