using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosSpawn : MonoBehaviour
{
    public Transform [] spawnPoints;
    public GameObject [] enemy;
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating ("SpawnAMonster", 0f, 1f);
    }

    // Update is called once per frame
    void SpawnAMonster()
    {
        if (spawnAllowed){
            randomSpawnPoint = Random.Range (0, spawnPoints.Length);
            randomMonster = Random.Range (0, enemy.Length);
            Instantiate (enemy [randomMonster], spawnPoints [randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
