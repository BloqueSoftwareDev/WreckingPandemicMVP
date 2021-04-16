using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que el jugador pueda saltar
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class Jump : MonoBehaviour
{
    [SerializeField] Vector2 jumpHeight;
    public HorizontalMotion knocked;
    public PlayerHealth invuln;
    int jumpLim = 1;
    private Rigidbody2D groundCheck;
    public Animator animator;
    bool inWall;
    public GameObject jumpSFX;
    public GameObject landSFX;
    public GameObject damageSFX;
    // Start is called before the first frame update
    void Start()
    {
        groundCheck = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && jumpLim > 0 && !inWall)
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            jumpLim--;
            animator.SetTrigger("Jump");
            animator.ResetTrigger("Landing");
            jumpSFX.SetActive(true);
            landSFX.SetActive(false);
        }
        
    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag != "Enemy" && other.tag != "Miniboss")
        {
            invuln.invulnerable = false;
            knocked.knockbackCount = 0;
            jumpLim = 1;
            animator.ResetTrigger("Jump");
            animator.SetTrigger("Landing");
            landSFX.SetActive(true);
            jumpSFX.SetActive(false);
            damageSFX.SetActive(false);

            if(other.tag == "Wall")
            {
                inWall = true;
            }
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Wall")
        {
            inWall = false;
        }
    }

    
}
