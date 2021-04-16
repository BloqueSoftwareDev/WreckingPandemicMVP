using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que el spray destruya a los enemigos
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class EnemyDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
