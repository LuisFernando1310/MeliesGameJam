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
    public GameObject tutopedrasJorge;

    public AudioSource Gameplay;

    public LuisaController scriptluisa;
    public JorgeOK scriptjorge;

    private void Start()
    {
        //aqui trava os scripts
        scriptjorge.GetComponent<JorgeOK>().enabled = false;
        scriptluisa.GetComponent<LuisaController>().enabled = false;
        Invoke("Fala2", 7f);
    }

    void Fala2()
    {
        Gameplay.Play();
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
       scriptluisa.GetComponent<LuisaController>().enabled = true;
       scriptjorge.GetComponent<JorgeOK>().enabled = true;
        MovimentacaoJorge.SetActive(true);
        MovimentacaoLuisa.SetActive(true);
        Invoke("TutoMedo", 4f);
    }

    void TutoMedo()
    {
        MovimentacaoJorge.SetActive(false);
        MovimentacaoLuisa.SetActive(false);
        tutomedo.SetActive(true);
        Invoke("TutoPedras", 6f);
    }

    void TutoPedras()
    {
        tutomedo.SetActive(false);
        tutopedras.SetActive(true);
        tutopedrasJorge.SetActive(true);
        Invoke("Acaboututo", 8f);

    }

    void Acaboututo()
    {
        tutopedras.SetActive(false);
        tutopedrasJorge.SetActive(false);
    }


}
