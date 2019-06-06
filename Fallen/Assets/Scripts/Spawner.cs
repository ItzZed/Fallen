using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;
    public Transform[] spawnSpots;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;

    void Start() {

        timeBtwSpawns = startTimeBtwSpawns;

    }

    void Update() {
        
        if(timeBtwSpawns <= 0) {

            int randPos = Random.Range(0, spawnSpots.Length -1);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;

        }
        else {

            timeBtwSpawns -= Time.deltaTime;

        }

    }
}
