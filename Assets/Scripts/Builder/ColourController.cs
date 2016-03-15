using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColourController : MonoBehaviour
{
    public Color holdingColour = Color.white;

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 50), "Back"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
