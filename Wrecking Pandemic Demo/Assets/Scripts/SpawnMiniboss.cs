using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para hacer que aparezca el miniboss
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class SpawnMiniboss : MonoBehaviour
{
    public GameObject miniboss;
    public GameObject bosshpbar;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            miniboss.SetActive(true);
            bosshpbar.SetActive(true);
        }
    }
}
