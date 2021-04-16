using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que el enemigo se mueva automaticamente horizontalmente
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class HorizontalAuto : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    Vector3 motion;
    float direction = 1;
    bool goingRight = true;
    [SerializeField] SpriteRenderer sprite;

    // Update is called once per frame
    void Update()
    {
        if(goingRight)
        {
            direction = -1;
            sprite.flipX = true;
        }
        if(!goingRight)
        {
            direction = 1;
            sprite.flipX = false;
        }
        motion.x = direction;
        transform.position = transform.position + motion * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy") 
        {
            if(goingRight == true)
            {
                goingRight = false;
            }
            else
            {
                goingRight = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Wall") 
        {
            if(goingRight == true)
            {
                goingRight = false;
            }
            else
            {
                goingRight = true;
            }
        }
    }
}
