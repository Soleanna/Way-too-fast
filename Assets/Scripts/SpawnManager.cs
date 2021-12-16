using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    public GameObject[] vehiclePrefabsRight;
    private float spawnPosZ = 100;

    private float startDelay = 1;
    public static float spawnInterval = 1.5f;
    public static float spawnIntervalR = 3f;

    public Transform RightSpawner;

    // Start is called before the first frame update
    void Start()
    {
        // Car Spawning
        StartCoroutine("LeftSpawnRandomCar");
        StartCoroutine("RightSpawnRandomCar");
       // InvokeRepeating("LeftSpawnRandomCar", startDelay, spawnInterval);
       // InvokeRepeating("RightSpawnRandomCar", startDelay, spawnIntervalR);
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    
    // Car Spawning Methods
    /*void LeftSpawnRandomCar()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-7, -1), 1.25f, spawnPosZ);
        int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
        Instantiate(vehiclePrefabs[vehicleIndex], spawnPos, vehiclePrefabs[vehicleIndex].transform.rotation);
    }*/
    /*void RightSpawnRandomCar()
    {
        Vector3 spawnPos = new Vector3(Random.Range(7, 1), 1.25f, spawnPosZ);
        int vehicleIndex = Random.Range(0, vehiclePrefabsRight.Length);
        Instantiate(vehiclePrefabsRight[vehicleIndex], spawnPos, RightSpawner.rotation);
    }*/
    IEnumerator LeftSpawnRandomCar()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Vector3 spawnPos = new Vector3(Random.Range(-7, -1), 1.25f, spawnPosZ);
            int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
            Instantiate(vehiclePrefabs[vehicleIndex], spawnPos, vehiclePrefabs[vehicleIndex].transform.rotation);
        }
    }
    IEnumerator RightSpawnRandomCar()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnIntervalR);
            Vector3 spawnPos = new Vector3(Random.Range(7, 1), 1.25f, spawnPosZ);
            int vehicleIndex = Random.Range(0, vehiclePrefabsRight.Length);
            Instantiate(vehiclePrefabsRight[vehicleIndex], spawnPos, RightSpawner.rotation);
        }
    }
}
