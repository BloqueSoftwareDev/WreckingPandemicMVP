using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para que la camara siga a un objeto
//Autores: Ian Seidman, Javier Corona, Gabriel Dichi

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    [SerializeField] public float speed;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
