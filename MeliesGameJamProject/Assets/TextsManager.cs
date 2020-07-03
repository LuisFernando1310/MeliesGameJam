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

    public AudioSource Gameplay;

    public LuisaController scriptluisa;
    public JorgeOK scriptjorge;

    private void Start()
    {
        //aqui trava os scripts
        scriptjorge.GetComponent<LuisaController>().enabled = false;
        scriptluisa.GetComponent<JorgeOK>().enabled = false;
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
        Invoke("TutoPedras", 4f);
    }

    void TutoPedras()
    {
        tutomedo.SetActive(false);
        tutopedras.SetActive(true);
        Invoke("AcabouTuto", 4f);

    }

    void Acaboututo()
    {
        tutopedras.SetActive(false);
    }
}
