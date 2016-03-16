using UnityEngine;
using System.Collections;

public class AwesomeScript : MonoBehaviour
{
    [SerializeField]
    Texture2D explosion, text;
    Vector2 explosionSize, textSize;
    GameController gameController;
    bool explosionOn = false;
    int stage = 0;
    int timer = 50;
    float textPosY = 0;
    
    void Start()
    {
        explosionSize = new Vector2(0, 0);
        textSize = new Vector2(Screen.width/ 1.3f, Screen.height / 2);
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void FixedUpdate()
    {
        switch (stage)
        {
            case 0:
                {
                    textSize -= new Vector2(9.0f, 3.0f);
                    if(textSize.x <= 200)
                    {
                        stage = 1;
                        explosionOn = true;
                    }
                    break;
                }
            case 1:
                {
                    if (textSize.x > 190 && textSize.x < 250)
                    {
                        textSize += new Vector2(4.0f, 1.2f);
                    }

                    explosionSize += new Vector2(9.0f, 3.0f);
                    if(explosionSize.x >= 400)
                    {
                        stage = 2;
                    }
                    break;
                }
            case 2:
                {
                    timer--;
                    if (explosionSize.x > 370 && explosionSize.x < 420)
                    {
                        explosionSize -= new Vector2(4.0f, 1.2f);
                    }
                    if(timer <= 0)
                    {
                        stage = 3;
                    }
                    break;
                }
            case 3:
                {
                    explosionSize -= new Vector2(8.0f, 2.4f);
                    if(explosionSize.x <= 0)
                    {
                        explosionOn = false;
                    }
                    textPosY += 2.0f;
                    if(textPosY >= 176)
                    {
                        stage = 4;
                    }
                    break;
                }
            case 4:
                {
                    gameController.doneWithAnimation = true;
                    break;
                }
        }
    }
    
    void OnGUI()
    {
        if (explosionOn)
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - (explosionSize.x / 2), Screen.height / 2 - (explosionSize.y / 2), explosionSize.x, explosionSize.y), explosion);
        }
        GUI.DrawTexture(new Rect(Screen.width / 2 - (textSize.x / 2), Screen.height / 2 - (textSize.y / 2) - textPosY, textSize.x, textSize.y), text);
    }
}
