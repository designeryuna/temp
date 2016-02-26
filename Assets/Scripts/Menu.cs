using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour 
{
    [SerializeField]
    Texture2D locked;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 25, Screen.height / 2, 150, 50), "Build Asteroid"))
        {
            SceneManager.LoadScene("BuildPack");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 25, Screen.height / 2 + 50, 150, 50), locked))
        {
            
        }
    }
}
