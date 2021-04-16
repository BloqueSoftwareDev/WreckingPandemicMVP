using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script para poner mensaje cuando agarras objeto "Hydrogen" y mandar a minigame al presionar spacebar
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class GetSecondElement : MonoBehaviour
{
    public bool hasGrabbed = false;
    public GameObject target;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Hydrogen")
        {
            target.SetActive(true); 
            hasGrabbed = true; 
        }            
    }

    void Update()
    {
        if(hasGrabbed)
        {
            if(Input.GetKeyDown("space"))
            {
                target.SetActive(false);
                SceneManager.LoadScene("Minigame1"); 
            }
        }

    }
}
