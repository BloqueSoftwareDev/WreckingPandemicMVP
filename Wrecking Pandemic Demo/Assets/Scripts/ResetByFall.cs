using UnityEngine;
using UnityEngine.SceneManagement;

//Script para que el jugador pierda si toca a este objeto
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class ResetByFall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {       
            SceneManager.LoadScene("Death"); 
        }

    }
}
