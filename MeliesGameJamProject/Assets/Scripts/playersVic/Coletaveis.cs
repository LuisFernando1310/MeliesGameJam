using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Coletaveis : MonoBehaviour
{

    public LuisaController scriptLuisa;

    public MeshRenderer meshRenderer;

    public GameObject pointLight;

    public BoxCollider boxCollider;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Luisa"))
        {
            audioSource.PlayOneShot(clip);
            meshRenderer.enabled = false;
            boxCollider.enabled = false;
            pointLight.gameObject.SetActive(false);
            scriptLuisa.chaves++;
        }
    }
}
