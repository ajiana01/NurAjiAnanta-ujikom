using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefab;
    [SerializeField] private float spawnInterval = 2;

    [SerializeField] private float SpawnCount = 1;

    [SerializeField] private Transform spawnPoint;

    [SerializeField] private float minXSpawn, maxXSpawn;

    private float currentSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        currentSpawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnAnimalCount();
    }

    void SpawnAnimal()
    {
        int animal = Random.Range(0, animalPrefab.Length);
        float RandomX = Random.Range(minXSpawn, maxXSpawn);

        Vector3 position = new Vector3(RandomX, 0, spawnPoint.position.z);
        Instantiate(animalPrefab[animal], position, animalPrefab[animal].transform.rotation);
    }

    /*IEnumerator SpawnAnimalCount()
    {
        SpawnAnimal();
        yield return new WaitForSeconds(SpawnCount/spawnInterval);
    }*/

    void SpawnAnimalCount()
    {
        if (currentSpawnTime <= 0)
        {
            currentSpawnTime = SpawnCount / spawnInterval;
            SpawnAnimal();
            Debug.Log(currentSpawnTime);
        }
        currentSpawnTime -= Time.deltaTime;
    }
}
