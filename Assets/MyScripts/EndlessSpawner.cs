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
    static public int enemiesAlive = 0;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }
    IEnumerator SpawnEnemies()
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