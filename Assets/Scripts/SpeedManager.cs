using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public float speedBump = 0.02f;
    public float spawnBump = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpeedUp");
        StartCoroutine("SpawnUp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpeedUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            LeftsideMovement.speed += speedBump;
            RightsideMovement.rSpeed += speedBump;
            MoveDown.gSpeed += speedBump;
        }
    }
    IEnumerator SpawnUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            SpawnManager.spawnInterval *= spawnBump;
            SpawnManager.spawnIntervalR *= spawnBump;
            Debug.Log(SpawnManager.spawnInterval);
        }
    }
}
