using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaVoa : MonoBehaviour
{
    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x <= -5){
            Destroy(gameObject);  
        }
    }
}
