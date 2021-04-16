using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    public List<Transform> checkpoints = new List<Transform> {}; 
    public Transform emily;
    public GameObject potion2;
    
    // Start is called before the first frame update
    void Start()
    {
        int Index = PlayerPrefs.GetInt("continue",0); 

        emily.position = checkpoints[Index].position;

        if(Index > 0)
        {
            Destroy(potion2);
            emily.GetComponent<Spray>().sprayCan = true;
        }
    }

}
