using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que el jugador se pueda mover horizontalmente
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class HorizontalMotion : MonoBehaviour
{
    Vector3 motion;
    [SerializeField] SpriteRenderer sprite;
    public Animator animator;
    [SerializeField] float speed;
    bool facingRight = true;
    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;

    // Update is called once per frame
    void Update()
    {
        if(knockbackCount <= 0)
        {
            motion.x = Input.GetAxisRaw("Horizontal");
            transform.position = transform.position + motion*speed*Time.deltaTime;
        if((Input.GetKeyDown(KeyCode.A) ||(Input.GetKeyDown(KeyCode.LeftArrow))) && facingRight)
        {
            transform.Rotate(0f, 180f, 0f);
            facingRight = false;
        }
        if((Input.GetKeyDown(KeyCode.D) ||(Input.GetKeyDown(KeyCode.RightArrow))) && !facingRight)
        {
            transform.Rotate(0f, 180f, 0f);
            facingRight = true;
        }
            animator.SetFloat("Speed", Mathf.Abs(motion.x*speed));
        }
        else
        {
            if(knockFromRight)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-knockback*3, knockback/2));
            }
            if(!knockFromRight)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(knockback*3, knockback/2));
            }
            knockbackCount-=Time.deltaTime;
        }

        
    }
}
