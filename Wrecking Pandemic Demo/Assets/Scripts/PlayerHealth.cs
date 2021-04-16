using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script para que el jugador tenga vida, pierda vida si es golpeado, y pierda si llega a 0
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public SetHealthBar healthBar;
    public HorizontalMotion mover;
    public bool invulnerable = false;
    public GameObject damageSFX;

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
            SceneManager.LoadScene("Death"); 
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if((other.tag == "Enemy" || other.tag == "Miniboss") && !invulnerable)
        {
            damageSFX.SetActive(true);
            TakeDamage(1);
            mover.knockbackCount = mover.knockbackLength;

            if(other.transform.position.x > transform.position.x)
            {
                mover.knockFromRight = true;
            }
            else
            {
                mover.knockFromRight = false;
            }
            invulnerable = true;
        }
    }
}
