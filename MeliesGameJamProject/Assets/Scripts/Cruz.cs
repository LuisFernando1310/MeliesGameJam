using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cruz : MonoBehaviour
{
    public BarraMedoo scriptbarramedo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Luisa")
            scriptbarramedo.medao = true;
    }
}
