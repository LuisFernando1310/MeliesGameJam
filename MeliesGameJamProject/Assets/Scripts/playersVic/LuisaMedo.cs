using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuisaMedo : MonoBehaviour
{
    [SerializeField]
    BarraMedoo barraDeMedo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jorge")
            barraDeMedo.medo = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Jorge")
            barraDeMedo.medo = true;
    }
}
