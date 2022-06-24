using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliens : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alienss;
    
    private void OnMouseDown()
    {
       
        alienss.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Limit")
        {
            alienss.SetActive(false);
        }
    }
}
