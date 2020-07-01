using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FalasCutScenes : MonoBehaviour
{

    public GameObject luisaf1;
    public GameObject luisaf2;
    public GameObject jorgef1;
    public GameObject jorgef2;

    // Start is called before the first frame update
    void Start()
    {
        luisaf1.SetActive(true);
        luisaf2.SetActive(false);
        jorgef1.SetActive(false);
        jorgef2.SetActive(false);
        Invoke("Jorge1", 5f);
    }

    public void Jorge1()
    {
        luisaf1.SetActive(false);
        luisaf2.SetActive(false);
        jorgef1.SetActive(true);
        jorgef2.SetActive(false);
        Invoke("Luisa2", 5f);
    }

    public void Luisa2()
    {
        luisaf1.SetActive(false);
        luisaf2.SetActive(true);
        jorgef1.SetActive(false);
        jorgef2.SetActive(false);
        Invoke("Jorge2", 5f);
    }

    public void Jorge2()
    {
        luisaf1.SetActive(false);
        luisaf2.SetActive(false);
        jorgef1.SetActive(false);
        jorgef2.SetActive(true);
        Invoke("Apaga", 5f);
    }

    public void Apaga()
    {
        luisaf1.SetActive(false);
        luisaf2.SetActive(false);
        jorgef1.SetActive(false);
        jorgef2.SetActive(false);
        Invoke("StartGame", 3f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
