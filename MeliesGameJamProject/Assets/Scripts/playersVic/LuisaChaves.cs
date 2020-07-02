using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuisaChaves : MonoBehaviour
{
    public int chaves = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            other.gameObject.SetActive(false);
            chaves++;
        }
    }
}
