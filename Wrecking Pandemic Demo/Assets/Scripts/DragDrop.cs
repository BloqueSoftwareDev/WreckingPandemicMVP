using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para poder mover objetos con el cursor
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    public LayerMask slotLayer;
    public float radius;
    private Collider2D assignedSlot;

    public void OnMouseDown()
    {
        Debug.Log("mouse down");
        isDragging = true;

        assignedSlot.gameObject.GetComponent<DropSpot>().Correct = false;     

    }

    // Update is called once per frame
    public void OnMouseUp()
    {
      isDragging = false;
      Debug.Log("mouse up");

      Collider2D slot = Physics2D.OverlapCircle(transform.position, radius, slotLayer);

      if (slot != null)
      {
          print(slot.transform.position + "hola");
          transform.position = slot.transform.position;

          assignedSlot = slot;

        if(GetComponent<Potion_Element>().Element == slot.gameObject.GetComponent<DropSpot>().ChemElemnt)
        {
           slot.gameObject.GetComponent<DropSpot>().Correct = true;
        }
      }


    }

 void Update()
    {

        
        if (isDragging == true)
        {
            
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
            //print(mousePosition);



            transform.Translate(mousePosition);      

        }
    }

    void OnDrawGizmosSelected()
    {
        
        Gizmos.DrawWireSphere(transform.position, radius);
        
    }



}

