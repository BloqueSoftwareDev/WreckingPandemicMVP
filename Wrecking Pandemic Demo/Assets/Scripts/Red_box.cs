using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script para que el jugador pierda si toca a este objeto
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi


public class Red_box : MonoBehaviour
{
    public List<DropSpot> Slots = new List<DropSpot> {};
    
    private int cont;
    private int contador_errores;

    
     
    void Update()
    {


        if(Input.GetKeyDown(KeyCode.R))
        {
            Mix();
        }
    }

    public void Mix()
    {
        cont = 0;
        
        foreach(DropSpot i in Slots)
        {

            if (i.Correct == true)
            {
                cont ++;
            }

            if (cont == Slots.Count)
            {
                print ("ganaste");

                PlayerPrefs.SetInt("continue",1);
                SceneManager.LoadScene("Level1");
            }

            else {
                print ("SIgue intentando");
                contador_errores ++;
                print(contador_errores);
                
            }
        }     
    }
    






}
