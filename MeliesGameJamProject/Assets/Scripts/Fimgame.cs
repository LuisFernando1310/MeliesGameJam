using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fimgame : MonoBehaviour
{
    public GameObject terminougame;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Luisa") 
        {
            terminougame.SetActive(true);
        }


        
    }


}
