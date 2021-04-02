using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{

    public float Velocidade;
    public float ForcaPulo;

    private Rigidbody2D rig;
    private Animator anim;


    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {

        rig.velocity = new Vector2(Velocidade, rig.velocity.y);
    
        anim.SetBool("walk",true);

    }
    
    void Jump()
    {   

        if(Input.GetMouseButtonDown(0) && !isJumping){

            rig.AddForce(Vector2.up * ForcaPulo, ForceMode2D.Impulse);
            isJumping = true;
            anim.SetBool("jump", true);
        }
    }

    void OnCollisionEnter2D(Collision2D colisor){

        if(colisor.gameObject.layer == 8){
            isJumping = false;
            anim.SetBool("jump", false);
        }
    }
}