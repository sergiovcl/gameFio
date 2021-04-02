using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
        
    public Sprite[] enemySprites; 

    public GameObject piranhaPrefabRef;

    float interval = 3; // em segundos
    float intantiateTime = 0;
    float intervalVariation = 0.5f;

    public bool stopSpawn = false;

    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > intantiateTime && !stopSpawn){

            GameObject obj = Instantiate(piranhaPrefabRef, new Vector3(12.26f, -0.4f), Quaternion.identity);
            obj.GetComponent<SpriteRenderer>().sprite = enemySprites[Random.Range(0, enemySprites.Length)];
            obj.AddComponent<BoxCollider2D>();
            obj.GetComponent<Piranha>().speed = speed;
            intantiateTime = Time.time + Random.Range(interval - intervalVariation, intervalVariation + intervalVariation);
        }
    }
}
