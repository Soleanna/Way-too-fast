using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public float speedBump = 0.02f;
    public float spawnBump = 0.5f;

    private GameManager GM;


    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine("SpeedUp");
        StartCoroutine("SpawnUp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(1);
        if (GM.isGameActive)
        {
            LeftsideMovement.speed += speedBump;
            RightsideMovement.rSpeed += speedBump;
            MoveDown.gSpeed += speedBump;
            Debug.Log(speedBump);
        }
        StartCoroutine(SpeedUp());
    }
    IEnumerator SpawnUp()
    {
        yield return new WaitForSeconds(10);
        if (GM.isGameActive)
        {           
            SpawnManager.spawnInterval -= 1 / spawnBump;
            SpawnManager.spawnIntervalR -= 1 / spawnBump;
        }
        StartCoroutine(SpawnUp());
    }
}
