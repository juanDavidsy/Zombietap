using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiesMovement : MonoBehaviour
{
    
    [Header("Movimiento del personaje")]
    public float speedMovement;
    public Vector3 direccion;
    public float tiempo = 0;
    // Update is called once per frame
    void Update()
    {
        direccion.y = -1;
        transform.Translate(direccion * speedMovement * Time.deltaTime);
        if(tiempo >= 15)
        {
            speedMovement = 5;
        }
        tiempo += Time.deltaTime;
    }
}
  



