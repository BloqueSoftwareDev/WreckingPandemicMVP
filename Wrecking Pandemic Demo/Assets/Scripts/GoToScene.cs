/*
Change to another scene
Gilberto Echeverria
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public void ChangeScene(string scene)
    {
        if(scene == "Level1")
        {
            PlayerPrefs.SetInt("continue",0); 
        }
        SceneManager.LoadScene(scene);
    }
}