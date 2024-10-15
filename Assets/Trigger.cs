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
        doorWall.SetActive(false);
    }
    }
    void OnTriggerExit2D(Collider2D Collider)
    {
            if(Collider.gameObject.CompareTag("Player"))
    {
        doorWall.SetActive(true);
    }
    }
}
