using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefab;
    [SerializeField] private float repeatingSpawn = 2;
    [SerializeField] private float startDelay = 2;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatingSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalPrefab.Length);
        int spawnRangeX = Random.Range(-20, 20);
        int spawnPosZ = 35;
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, spawnPosZ);
            
        Instantiate(animalPrefab[animalIndex],
            spawnPos,
            animalPrefab[animalIndex].transform.rotation);
    }
}
