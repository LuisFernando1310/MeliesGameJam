using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ultimaporta : MonoBehaviour
{
    public Animator animportasaida;
    public LuisaController scriptLuisa;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Luisa" && scriptLuisa.chaves == 3)
        {
            animportasaida.SetBool("abre", true);
        }
    }
}
