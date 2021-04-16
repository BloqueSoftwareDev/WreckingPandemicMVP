using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que el jugador dispare un proyectil cuando presione la tecla p
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class Spray : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] GameObject sprayCloud;
    public Animator animator;
    public GameObject spraySFX;
    public bool sprayCan = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P) && sprayCan)
        {
            sprayCloud.SetActive(true);
            animator.SetTrigger("Firing");
            animator.ResetTrigger("NotFiring");
            spraySFX.SetActive(true);

        }
        if(Input.GetKeyUp(KeyCode.P) && sprayCan)
        {
            sprayCloud.SetActive(false);
            animator.SetTrigger("NotFiring");
            animator.ResetTrigger("Firing");
            spraySFX.SetActive(false);
        }
    }

}
