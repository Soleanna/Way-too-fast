using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    public GameObject[] vehiclePrefabsRight;
    private float spawnPosZ = 100;

    public static float spawnInterval = 1.5f;
    public static float spawnIntervalR = 3f;

    public Transform RightSpawner;

    public GameManager GM;
    public GameObject theGameManager;

    // Start is called before the first frame update
    void Start()
    {
        GM = GM.GetComponent<GameManager>();
        theGameManager = GameObject.Find("TheGameManager");

        // Car Spawning
        StartCoroutine("LeftSpawnRandomCar");
        StartCoroutine("RightSpawnRandomCar");
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    
    // Car Spawning Methods

    IEnumerator LeftSpawnRandomCar()
    {
        yield return new WaitForSeconds(spawnInterval);
        if (GM.isGameActive)
        {
            
            Vector3 spawnPos = new Vector3(Random.Range(-7, -1), 1.25f, spawnPosZ);
            int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
            Instantiate(vehiclePrefabs[vehicleIndex], spawnPos, vehiclePrefabs[vehicleIndex].transform.rotation);
        }
        StartCoroutine(LeftSpawnRandomCar());
    }
    IEnumerator RightSpawnRandomCar()
    {
        yield return new WaitForSeconds(spawnIntervalR);
        if (GM.isGameActive)
        {
            
            Vector3 spawnPos = new Vector3(Random.Range(7, 1), 1.25f, spawnPosZ);
            int vehicleIndex = Random.Range(0, vehiclePrefabsRight.Length);
            Instantiate(vehiclePrefabsRight[vehicleIndex], spawnPos, RightSpawner.rotation);
        }
        StartCoroutine(RightSpawnRandomCar());
    }
}
