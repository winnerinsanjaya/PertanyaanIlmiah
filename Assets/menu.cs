using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string scene;
    public GameObject menuSinopsise;
    public GameObject menuCredit;
   

    public void play()
    {
        SceneManager.LoadScene(scene);
    
    
    }

    public void openSinopsise()
    {
        if (menuSinopsise != null)
        {
            menuSinopsise.SetActive(true);
        }
    }
    public void closeSinopsise()
    {
        if (menuSinopsise != null)
        {
            menuSinopsise.SetActive(false);
        }
    }



    public void openCredit()
    {
        if (menuCredit != null)
        {
            menuCredit.SetActive(true);
        }
    }
    public void closeCredit()
    {
        if (menuCredit != null)
        {
            menuCredit.SetActive(false);
        }
    }
}
