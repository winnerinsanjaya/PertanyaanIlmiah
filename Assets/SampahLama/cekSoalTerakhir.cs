using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekSoalTerakhir : MonoBehaviour
{
    public string tagg;
    public SoalTerakhir script;

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
