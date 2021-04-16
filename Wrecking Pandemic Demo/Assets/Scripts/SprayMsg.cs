using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayMsg : MonoBehaviour
{

    public GameObject sprayMsg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            sprayMsg.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            sprayMsg.SetActive(true);
        }
    }
}
