using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    public float spawnInterval;
    public float minimumSpawnInterval;
    public float intervalDecrease;
<<<<<<< HEAD
    static public int enemiesAlive = 0;
=======
    public int enemiesAlive;
>>>>>>> 4de2797439dabd0a131961969bed38577b6ff1e7

    private void Update()
    {
        StartCoroutine(SpawnEnemies());
    }
    IEnumerator SpawnEnemies()
    {
        if (enemiesAlive < 1)
        {
            while (enemiesAlive < 10)
            {
                if (objectToSpawn != null && spawnPoint != null)
                {
                    Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
                    enemiesAlive += 1;
                    if (enemiesAlive == 1)
                    {
                        Debug.Log(enemiesAlive + " enemy alive");
                    }
                    else
                    {
                        Debug.Log(enemiesAlive + " enemies alive");
                    }
                }
                else
                {
                    Debug.LogWarning("Object to spawn point is not set.");
                }
                yield return new WaitForSeconds(spawnInterval);
                spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - intervalDecrease);
            }
        }
    }
}