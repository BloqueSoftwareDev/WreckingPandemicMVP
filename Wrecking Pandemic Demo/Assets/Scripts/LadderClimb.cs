using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que el jugador pueda escalar por objetos de escalera
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class LadderClimb : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float inputHorizontal;
    private float inputVertical;
    public float distance;
    public LayerMask whatIsLadder;
    private bool isClimbing;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputHorizontal * speed, rb.velocity.y);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position-new Vector3(0,1,0), Vector2.up, distance, whatIsLadder);

        if(hitInfo.collider != null){
            if(Input.GetKeyDown(KeyCode.W)){
                isClimbing = true;
            }
        }
        else{
            isClimbing = false;
        }

        if(isClimbing == true){
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(0, inputVertical * speed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 5;
        }
    }

}