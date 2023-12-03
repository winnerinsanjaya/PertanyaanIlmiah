using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekSoal : MonoBehaviour
{
    public string tagg;
    public SalahOrBenar script;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            script.panel.SetActive(true);
        }
    }



    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
