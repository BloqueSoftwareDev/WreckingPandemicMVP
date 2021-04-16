using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que el jugador pueda obtener objetos "pickable"
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class Pickables : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "pickable")
        {
            Destroy(other.gameObject);    
        }
    }
}
