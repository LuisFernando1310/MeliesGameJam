using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text txt;
    public string textoFala;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(ditado(textoFala));

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ditado(string frase)
    {
        int letra = 0;
        txt.text = "";

        while (letra < frase.Length)
        {
            txt.text += frase[letra];
            yield return new WaitForSeconds(DefineTempoDeEspera(frase[letra]));
            letra += 1;
            //yield return null;
        }
    }

    float DefineTempoDeEspera(char caractere)
    {
        switch (caractere)
        {
            case ',':
            case '.':
                return 0.3f;
            case ' ':
                return 0.06f;
            case '!':
            case '?':
                return 0.5f;
            default:
                return 0.03f;
        }
    }
}
