using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BuildPackController : MonoBehaviour 
{
    int screen = 0;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnGUI()
    {
        if (screen == 0)
        {
            GUI.Label(new Rect(Screen.width / 3, 10, 100, 25), "BuildPack");
            GUI.Label(new Rect(Screen.width / 3, 50, 100, 25), "6 Mini Games");
            if (GUI.Button(new Rect(Screen.width / 3, Screen.height / 2, 100, 25), "Start"))
            {
                SceneManager.LoadScene("1-1");
                screen++;
            }
        }
    }
}
