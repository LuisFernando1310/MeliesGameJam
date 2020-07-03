using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuisaChaves : MonoBehaviour
{
    public int chaves = 0;
    public Animator animportasaida;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            other.gameObject.SetActive(false);
            chaves++;
        }

        if(other.tag == "portaofinal" && chaves == 3)
        {
           
        }
    }
}
