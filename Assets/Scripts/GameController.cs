using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool inGame = false;
    bool paused = false;
    [SerializeField]
    Texture2D pauseButton, playButton;
    public GUIStyle smallFont;
    public int totalScore;
    public bool toLevelSelect = false, doneWithMiniGame = false, won = false;
    public int lastMiniGame;
    public bool doneWithAnimation = false;
    bool once = false;
    [SerializeField]
    AwesomeScript awesomeScript;

    void Awake ()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    void OnGUI()
    {
        if (!doneWithMiniGame)
        {
            if (inGame && !paused)
            {
                if (GUI.Button(new Rect(0, 0, 50, 50), pauseButton, smallFont))
                {
                    paused = true;
                }
            }
        }
        if (paused)
        {
            Time.timeScale = 0.0f; // pause game
            if (GUI.Button(new Rect(0, 0, 50, 50), playButton, smallFont))
            {
                paused = false;
            }
            if (GUI.Button(new Rect(0, 100, 50, 50), "Back"))
            {
                paused = false;
                toLevelSelect = true;
                inGame = false;
                SceneManager.LoadScene("MainMenu");
            }
        }
        else
        {
            Time.timeScale = 1; // unpause game
        }

        if(doneWithMiniGame && ! once)
        {
            once = true;
            Instantiate(awesomeScript);
        }

        if(doneWithAnimation && doneWithMiniGame)
        {
            //GUI.TextArea(new Rect(0, 0, Screen.width, Screen.height),"");
            if (GUI.Button(new Rect(0, 100, 50, 50), "Back"))
            {
                once = false;
                paused = false;
                toLevelSelect = true;
                inGame = false;
                SceneManager.LoadScene("MainMenu");
            }
            if (won)
            {
                GUI.Label(new Rect(Screen.width / 2, 50, 100, 50), "You Win!!!");
                GUI.Label(new Rect(Screen.width / 2, 150, 100, 50), totalScore.ToString());
                if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2, 150, 50), "Next Level"))
                {
                    once = false;
                    Time.timeScale = 1;
                    SceneManager.LoadScene("MainMenu");
                }
            }
            else
            {
                GUI.Label(new Rect(Screen.width / 2, 50, 100, 50), "Try Again");
                if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2, 150, 50), "Restart"))
                {
                    once = false;
                    Time.timeScale = 1;
                    doneWithMiniGame = false;
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }
    }
}
