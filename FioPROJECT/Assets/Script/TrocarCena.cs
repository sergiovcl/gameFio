using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public string nomeDaCena;

    public void TrocarS()
    {
        SceneManager.LoadScene(nomeDaCena);

    }
    public void Sair()
    {
       Application.Quit(); 
    }
}
