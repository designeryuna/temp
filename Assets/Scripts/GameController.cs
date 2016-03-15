using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public bool inGame = false;
    bool paused = false;
    [SerializeField]
    Texture2D pauseButton, playButton;
    public GUIStyle smallFont;
    public int totalScore;

    void Awake ()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    void OnGUI()
    {
        if(inGame && !paused)
        {
            if (GUI.Button(new Rect(0, 0, 50, 50), pauseButton, smallFont))
            {
                paused = true;
            }
        }
        if(paused)
        {
            Time.timeScale = 0.0f; // pause game
            if (GUI.Button(new Rect(0, 0, 50, 50), playButton, smallFont))
            {
                paused = false;
            }
        }
        else
        {
            Time.timeScale = 1; // unpause game
        }
    }
}
