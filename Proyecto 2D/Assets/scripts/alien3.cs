using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien3 : MonoBehaviour
{
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
        gameObject.SetActive(false);
        GetComponent<zombiesMovement>().speedMovement = 7;

        GetComponent<Animator>().runtimeAnimatorController = personaje;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Limit")
        {
            gameObject.SetActive(false);
        }
    }
}
