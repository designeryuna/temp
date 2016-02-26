using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour 
{
    
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 25, Screen.height / 2, 150, 50), "Build Asteroid"))
        {
            SceneManager.LoadScene("BuildPack");
        }
    }
}
