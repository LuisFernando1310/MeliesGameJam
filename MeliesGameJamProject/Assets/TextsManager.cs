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
    public GameObject tutomedo;
    public GameObject tutopedras;

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
        tutomedo.SetActive(true);
        Invoke("TutoPedras", 4f);
    }

    void TutoPedras()
    {
        tutomedo.SetActive(false);
        tutopedras.SetActive(true);
    }

    void Acaboututo()
    {
        tutopedras.SetActive(false);
    }
}
