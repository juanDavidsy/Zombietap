using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiesMovement : MonoBehaviour
{
    
    [Header("Movimiento del personaje")]
    public float speedMovement;
    public Vector3 direccion;

    // Update is called once per frame
    void Update()
    {
        direccion.y = -1;
        transform.Translate(direccion * speedMovement * Time.deltaTime);
    }

}


