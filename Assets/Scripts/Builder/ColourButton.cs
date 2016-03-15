using UnityEngine;
using System.Collections;

public class ColourButton : MonoBehaviour
{
    [SerializeField]
    ColourController controller;
    Color thisColour;

    void Start()
    {
        thisColour = this.GetComponent<SpriteRenderer>().color;
    }

    void OnMouseDown()
    {
        controller.holdingColour = thisColour;
    }
}
