using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Principal : MonoBehaviour
{
    Jogador jogador;
    EnemySpawn enemySpawn;
    ChaoMovimento chaoMovimento;

    float timeToIncreaseDifficulty = 0;
    float interval = 5f;

    bool gameOver = false;

    public Text placarText;
    int placar;

    // Start is called before the first frame update
    void Start()
    {
        jogador        = FindObjectOfType<Jogador>();
        enemySpawn     = FindObjectOfType<EnemySpawn>();
        chaoMovimento  = FindObjectOfType<ChaoMovimento>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver){   

            if(Physics2D.OverlapBoxAll(jogador.transform.position, Vector2.one * 0.3f, 0, LayerMask.GetMask("Enemy")).Length > 0) {

                gameOver = true;

                enemySpawn.stopSpawn = true;

                chaoMovimento.speed = 0;

                Piranha[] allPiranhas = FindObjectsOfType<Piranha>();
                foreach (Piranha obj in allPiranhas)
                    obj.speed = 0;
                
            }

                //aumenta dificuldade
                if(Time.time >= timeToIncreaseDifficulty){
                    chaoMovimento.speed += 0.2f;
                    enemySpawn.speed += 0.2f;

                    placar += 100;
                    placarText.text = placar.ToString("D6");

                    timeToIncreaseDifficulty = Time.time + interval;
                }

        } else {
            //restart
            if(Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene(0);
            }
        }
    }
} 

