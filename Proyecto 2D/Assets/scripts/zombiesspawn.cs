using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiesspawn : MonoBehaviour
{
    Vector3 zombiespawn;
    float  tiempodesalida;
    public Transform ritghlimit, leftlimit;
    public float tiempodeaparicion;
    public GameObject [] zombies;
    
    private void Start()
    {
        zombiespawn = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if(tiempodesalida >= tiempodeaparicion)
        {
            foreach (GameObject z in zombies)
            {
                tiempodesalida = 0;
                if (z.activeInHierarchy == false)
                {
                    zombiespawn.x = Random.Range(ritghlimit.position.x, leftlimit.position.x);
                    z.transform.position = zombiespawn;
                    z.SetActive(true);
                    break;
                }
            }
        }
        tiempodesalida += Time.deltaTime;
    }
}
