using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCruzes : MonoBehaviour
{
    public GameObject falaluisa;
    public GameObject nomeLuisa;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Luisa")
        {
            falaluisa.SetActive(true);
            nomeLuisa.SetActive(true);
            Invoke("Desligafala", 3f);
        }



    }

    void Desligafala()
    {
        falaluisa.SetActive(false);
        nomeLuisa.SetActive(false);
    }
}
