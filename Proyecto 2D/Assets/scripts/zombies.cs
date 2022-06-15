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


}
