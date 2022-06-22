using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliensspawn : MonoBehaviour
{
    Vector3 aliensspawn;
    float tiempodesalida;
    public Transform midlimit, ritghlimit;
    public float tiempodeaparicion;
    public GameObject[] aliens;
    private void Start()
    {
        aliensspawn = transform.position;
    }
    void Update()
    {
        if (tiempodesalida >= tiempodeaparicion)
        {
            foreach (GameObject a in aliens)
            {
                tiempodesalida = 0;
                if (a.activeInHierarchy == false)
                {
                    aliensspawn.x = Random.Range(midlimit.position.x, ritghlimit.position.x);
                    a.transform.position = aliensspawn;
                    a.SetActive(true);
                    break;
                }
            }
        }
        tiempodesalida += Time.deltaTime;
    }
}

