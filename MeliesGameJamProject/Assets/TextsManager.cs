using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextsManager : MonoBehaviour
{
    public GameObject TextInicio;
    public GameObject TextInicio2;
    public GameObject jorge;
    public GameObject luisa;
    public GameObject MovimentacaoLuisa;
    public GameObject MovimentacaoJorge;

    private void Start()
    {
       
        Invoke("Fala2", 5f);
    }

    void Fala2()
    {
        
        TextInicio.SetActive(false);
        luisa.SetActive(false);
        //
        jorge.SetActive(true);
        TextInicio2.SetActive(true);
        Invoke("TutoMovimentacao", 6f);
    }

    void TutoMovimentacao()
    {
        jorge.SetActive(false);
        TextInicio2.SetActive(false);
        //
        MovimentacaoJorge.SetActive(true);
        MovimentacaoLuisa.SetActive(true);
        Invoke("TutoMedo", 4f);
    }

    void TutoMedo()
    {
        MovimentacaoJorge.SetActive(false);
        MovimentacaoLuisa.SetActive(false);
    }
}
