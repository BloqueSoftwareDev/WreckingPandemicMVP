using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Potion_Element : MonoBehaviour
{
    public string Element;
    public TMP_Text Label;
    void Start()
    {
        Label.text = Element;
        


    }

    
}
