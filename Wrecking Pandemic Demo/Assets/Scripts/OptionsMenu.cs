using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para hacer visible el canvas de opciones y creditos
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class OptionsMenu : MonoBehaviour
{
    public GameObject[] options;

    public void ChangeCanvas (int index)
    {
        foreach (var option in options)
        {
            option.SetActive(false);

        }
        options[index].SetActive(true);

    }



}
