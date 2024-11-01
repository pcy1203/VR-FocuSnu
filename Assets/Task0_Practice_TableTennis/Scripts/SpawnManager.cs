using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    private float spawnRangeX = 3;
    private float spawnRangeZ = 3;

    private float startDelay = 2;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBall() {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 10, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);
    }
}
