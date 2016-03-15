using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickerToStart : MonoBehaviour
{
    [SerializeField]
    float versionNumber;
    [SerializeField]
    Texture2D background;
    GUIStyle smallFont;

    void Start()
    {
        smallFont = GameObject.Find("GameController").GetComponent<GameController>().smallFont;
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);
        GUI.Label(new Rect(10, Screen.height - 25, 25, 25), versionNumber.ToString(), smallFont);
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 125, 25), "Click To Start", smallFont);
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
