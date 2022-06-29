using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public GameObject gameover;
    public Image corazon;
    public int cantdecorazones;
    public RectTransform posprimercorazon;
    public Canvas mycanva;
    public int offset;
    private void Start()
    {
        Transform poscorazon = posprimercorazon;
        for(int i = 0; i < cantdecorazones;i++)
        {
            Image newcorazon = Instantiate(corazon, poscorazon.position, Quaternion.identity);
            newcorazon.transform.parent = mycanva.transform;
            poscorazon.position = new Vector2(poscorazon.position.x + offset, poscorazon.position.y);
        }
        Destroy(corazon);
    }

    private void Update()
    {
        if(cantdecorazones <= 0)
        {
            gameObject.SetActive(false);
            gameover.SetActive(true);
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
 
        if (collision.tag == "Zombies")
        {
           
            mycanva.transform.GetChild(cantdecorazones - 1).gameObject.SetActive(false);
            cantdecorazones -= 1;
        }
    }
}
