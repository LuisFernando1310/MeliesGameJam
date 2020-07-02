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
    }


    void AumentaMedo()
    {
        valorMedo += 0.05f;
        AtualizaVida(valorMedo);
    }

    void AtualizaVida(float valormedo) // Atualiza a barra de fill
    {
        float amount = (valormedo / 100.0f) * 180.0f / 180;
        SliderMedo.fillAmount = amount;
        float indicadorAngle = amount * 180;
    }

    
}
