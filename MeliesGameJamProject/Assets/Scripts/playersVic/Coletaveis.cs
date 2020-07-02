using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletaveis : MonoBehaviour
{
    public int chave = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Luisa")
        {
            this.gameObject.SetActive(false);
            chave++;
        }

        
    }
}
