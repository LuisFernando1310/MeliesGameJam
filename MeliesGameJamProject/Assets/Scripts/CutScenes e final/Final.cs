using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject titulogame;
    public GameObject TEXTO;
    public GameObject botoes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ativatexto()
    {
        TEXTO.SetActive(true);
        Invoke("AtivaJorge", 6f);
    }

    public void AtivaJorge()
    {
        //toca animacao dele indo embora
        botoes.SetActive(true);
        TEXTO.SetActive(false);
        titulogame.SetActive(true);
    }
}
