using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        this.transform.Translate(speed, 0, 0);
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
