using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraMedoo : MonoBehaviour
{

    public Image SliderMedo;
    public float valorMedo;
    public float totalmedo = 100f;
    public bool medo;
    public bool medao;
    public bool morreu;
    public GameObject painelmorte;

    // Start is called before the first frame update
    void Start()
    {

        medo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(medo == true)
        {
            AumentaMedo();
        }

        if (medao == true)
        {
            AumentaMedoRapido();
        }

        VerificaMorte();
    }

    

    void AumentaMedo()
    {
        valorMedo += 0.02f;
        AtualizaVida(valorMedo);
    }

    public void AumentaMedoRapido()
    {
        valorMedo += 0.1f;
        AtualizaVida(valorMedo);
    }

    void AtualizaVida(float valormedo) // Atualiza a barra de fill
    {
        float amount = (valormedo / 100.0f) * 180.0f / 180;
        SliderMedo.fillAmount = amount;
        float indicadorAngle = amount * 180;
    }

    void VerificaMorte()
    {
        if(valorMedo >= 100)
        {
            Debug.Log("Morreu por medo");
            morreu = true;
            Invoke("AbrePainel", 2f);
        }

    }

    public void AbrePainel()
    {
        painelmorte.SetActive(true);
        Time.timeScale = 0;
    }
}
