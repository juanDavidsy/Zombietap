using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliens : MonoBehaviour
{
    // Start is called before the first frame update

    public RuntimeAnimatorController sangre;
    public RuntimeAnimatorController personaje;

    private void OnMouseDown()
    {
        GetComponent<zombiesMovement>().speedMovement = 0;
        GetComponent<Animator>().runtimeAnimatorController = sangre;
        StartCoroutine(WaitDead());
        
    }

    IEnumerator WaitDead()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<zombiesMovement>().speedMovement = 2;
        GetComponent<Animator>().runtimeAnimatorController = personaje;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Limit")
        {
           gameObject.SetActive(false);
        }
    }
}
