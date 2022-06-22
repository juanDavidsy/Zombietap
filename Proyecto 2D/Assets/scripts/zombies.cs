using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombies : MonoBehaviour
{
    public GameObject zombie;

    private void OnMouseDown()
    {
        zombie.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "Limit")
        {
            zombie.SetActive(false);
        }
    }
}
