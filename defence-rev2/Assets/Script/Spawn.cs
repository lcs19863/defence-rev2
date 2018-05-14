using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject hazard;
    public GameObject spawn;
    int hazardCount = 35;
    float spawnWait = 1f;
    public float startWait;
    public float waveWait = 20f;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnWaves());
    }
	

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i<hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawn.transform.position.x,spawn.transform.position.y, spawn.transform.position.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
