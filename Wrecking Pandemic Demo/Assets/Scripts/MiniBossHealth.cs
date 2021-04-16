using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script para que el miniboss tenga vida y desaparezca si baja a 0
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class MiniBossHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    public SetHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(currentHealth <= 0)
        {       
            SceneManager.LoadScene("Victory"); 
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Spray")
        {
            TakeDamage(1);
        }
    }
}
