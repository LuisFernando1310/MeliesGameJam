using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgeOK : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 5f;
    public bool andandoJ;

    Vector3 direcao;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Animator animator;
    public bool poderAtivado;
    public Animator animBotaoGrande;
    public Transform PosJorge;
    public GameObject tutopedrasJorge;

    [SerializeField]
    private Vector3 pos;

    public GameObject[] Cruz;

    public AudioSource audioSource;
    public AudioSource poder;

    private void Start()
    {
        transform.position = PosJorge.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        TocaAnimacao();
    }

    void Movimentacao()
    {
        
        pos = this.transform.position;
        pos.x += speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += speed * Input.GetAxis("Vertical") * Time.deltaTime;

        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") !=0)
        {
            direcao = (pos - this.transform.position).normalized;
            transform.forward = direcao;
        }  
        this.transform.position = pos;
    }

    void TocaAnimacao()
    {
        if(andandoJ == true)
        {
            animator.SetBool("andando", true);
            animator.SetBool("idle", false);
        }
        else
        {
            animator.SetBool("andando", false);
            animator.SetBool("idle", true);
        }

        if (Input.GetKey(KeyCode.E))
        {
            poderAtivado = true;
            animator.SetBool("poder", true);
            poder.Play();
        }
        else
        {
            animator.SetBool("poder", false);
            poderAtivado = false;
        }
    }


    //tutopedrasJorge.SetActive(true);

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "botaoG" && poderAtivado == true)
        {
            
            animBotaoGrande.speed = 0;
            Invoke("Desligartuto", 5);

        }

        if((other.tag == "CruzTorta" && poderAtivado == true))
        {
            Destroy(other.gameObject);
        }
    }

    void Desligatuto()
    {
        tutopedrasJorge.SetActive(false);
    }

    
}
