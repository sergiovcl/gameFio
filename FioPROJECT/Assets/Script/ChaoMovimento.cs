using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoMovimento : MonoBehaviour
{
    public SpriteRenderer[] grounds;

    public float speed = 3;
    Vector2 endPosition = new Vector2(-6.8f, -1f);
    Vector2 startPosition = new Vector2(15.64f, -1f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i< grounds.Length; ++i){
            grounds[i].transform.position += Vector3.left * speed * Time.deltaTime;
            if(grounds[i].transform.position.x <= endPosition.x){
                grounds[i].transform.position = startPosition;
            }
        }
    }
}
