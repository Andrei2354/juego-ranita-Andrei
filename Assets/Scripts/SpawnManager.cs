using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 1;
    private float spawnInterval = 0.5f;
    private float spawnPosZ = -6;
    public GameObject[] carsPrefabs;
    private Vector3[] spawnPositions;

    void Start() {
        spawnPositions = new Vector3[] {
            new Vector3(5, 0, spawnPosZ),
            new Vector3(-5, 0, spawnPosZ),
            new Vector3(-15, 0, spawnPosZ),
            new Vector3(-25, 0, spawnPosZ),
            new Vector3(-35, 0, spawnPosZ),
            new Vector3(-45, 0, spawnPosZ),
            new Vector3(-55, 0, spawnPosZ),
            new Vector3(-65, 0, spawnPosZ)
        };
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval); 
    }
    void Update() {
    }
    void SpawnRandomCar() {
        int carsIndex = Random.Range(0, carsPrefabs.Length);
        int positionIndex = Random.Range(0, spawnPositions.Length);
        Vector3 spawnPos = spawnPositions[positionIndex];
        Instantiate(carsPrefabs[carsIndex], spawnPos, carsPrefabs[carsIndex].transform.rotation);
    }
}
