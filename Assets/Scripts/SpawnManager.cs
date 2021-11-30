using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private Vector3 spawnPos;
    private float xRange = 15f;
    private float startTime = 2f;
    private float repeatRate = 1.5f;
    private float spawnZ = 25f;
    private float randomX;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startTime, repeatRate);
    }

    public Vector3 RandomSpawnPos()
    {
        randomX = Random.Range(-xRange, xRange);
        return new Vector3(randomX, 0, spawnZ);
    }
    
    public void SpawnAnimal()
    {
        randomIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = RandomSpawnPos();
        Instantiate(animalPrefabs[randomIndex], spawnPos, animalPrefabs[randomIndex].transform.rotation);
    }
    
}
