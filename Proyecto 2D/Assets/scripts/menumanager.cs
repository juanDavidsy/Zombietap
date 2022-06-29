using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Botonstart()
    {
        SceneManager.LoadScene("Game");
    }
    public  void Botonquit()
    {
        Application.Quit();
    }
    public void Botonout()
    {
      SceneManager.LoadScene("Menu");

        
    }
}
