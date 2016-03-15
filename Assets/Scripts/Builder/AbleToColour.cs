using UnityEngine;
using System.Collections;

public class AbleToColour : MonoBehaviour
{
    [SerializeField]
    ColourController controller;
    
    void OnMouseDown()
    {
        this.GetComponent<SpriteRenderer>().color = controller.holdingColour;
    }
}
