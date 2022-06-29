using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zigzag : MonoBehaviour
{
    // Start is called before the first frame update
    public float anchoCiclo, frecuencia;
    float cX, contador, xSen;

    public void Start()
    {
        cX = transform.position.x;
    }

    void Update()
    {
        contador = contador + (frecuencia / 100f);
        xSen = Mathf.Sin(contador);
        transform.position = new Vector3(cX + (xSen * anchoCiclo), transform.position.y, transform.position.z);
        if (contador > 6.28f)
        {
            contador = 0;
        }

    }
}
