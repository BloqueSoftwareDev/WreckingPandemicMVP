using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para poner mensaje en pantalla cuando agarras objeto "Oxygen" y luego desaparecer
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class GetFirstElement : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Oxygen")
        {
            target.SetActive(true);
            Destroy(other.gameObject);      
        }

        if(other.tag == "MsgDisable")
        {
            target.SetActive(false);
        }
    }
}
