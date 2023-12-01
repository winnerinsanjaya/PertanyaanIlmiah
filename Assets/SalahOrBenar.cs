using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalahOrBenar : MonoBehaviour
{
    public GameObject salahPanel;
    public GameObject panel;
    public GameObject crate;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void benar()
    {
        panel.SetActive(false);
        crate.SetActive(false);
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
