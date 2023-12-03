using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoalTerakhir : MonoBehaviour
{
    public GameObject salahPanel;
    public GameObject panel;
    public GameObject panelWin;
    public GameObject crate;
    public string next;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void benar()
    {
        panelWin.SetActive(true);
        panel.SetActive(false);
        Destroy(crate);
    }
    public void keluarWin()
    {
        SceneManager.LoadScene(next);
    }
    public void salah()
    {
        salahPanel.SetActive(true);
    }
    public void salahClose()
    {
        salahPanel.SetActive(false);
    }
}
