using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletaveis : MonoBehaviour
{

    public LuisaController scriptLuisa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Luisa"))
            {
            this.gameObject.SetActive(false);
            scriptLuisa.chaves++;
        }

       
    }
}
