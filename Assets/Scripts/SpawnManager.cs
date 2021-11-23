using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public Vector3 spawnPos = new Vector3(0, 0, 25);
    private float xRange = 15f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
    }

    public Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-xRange, xRange);
        return new Vector3(randomX, 0, 25);
    }
    
    public void SpawnAnimal()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = RandomSpawnPos();
        Instantiate(animalPrefabs[randomIndex], spawnPos, animalPrefabs[randomIndex].transform.rotation);
    }
    
}
