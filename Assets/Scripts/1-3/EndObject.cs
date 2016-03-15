using UnityEngine;
using System.Collections;

public class EndObject : MonoBehaviour 
{
    int total = 0;

    void Update()
    {
        if (total == 3)
        {

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BlueHuman")
        {
            Destroy(other.gameObject);
            total++;
        }
    }
}
