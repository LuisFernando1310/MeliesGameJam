using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuisaController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public bool andando;


    public bool empurrando;
    public Animator animator;
    public Animator animBotaoGrande;
    public Animator portaoChaves;
    public BarraMedoo scriptbarramedo;
    public Rigidbody caixa;

    public int chaves;

    void Update()
    {
        Movimentacao();
        TocaAnimacao();


    }

    void Movimentacao()
    {
        float horizontal = Input.GetAxisRaw("Horizontal2");
        float vertical = Input.GetAxisRaw("Vertical2");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            andando = true;
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0);

            controller.Move(direction * speed * Time.deltaTime);
        }

        else
        {
            andando = false;
        }
    }

    void TocaAnimacao()
    {
        if (andando == true)
        {
            animator.SetBool("andando", true);
            animator.SetBool("idle", false);
        }
        else
        {
            animator.SetBool("andando", false);
            animator.SetBool("idle", true);
        }

        
    }

    void Interagiveis()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("botaoG"))
        {
            Debug.Log("colidiu");
            animBotaoGrande.speed = 0;
        }

        if (collision.gameObject.CompareTag("botaoF"))
        {
            Debug.Log("abre");
            portaoChaves.SetBool("todaschaves", true);
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cruz"))
        {
            scriptbarramedo.medao = true;

        }
        else
        {
            scriptbarramedo.medao = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "caixa")
        {
            if (Input.GetKey(KeyCode.RightControl))
            {
                empurrando = true;
                animator.SetBool("empurra", true);
                caixa.AddForce(transform.forward * 20);
            }
            else
            {
                animator.SetBool("empurra", false);
                empurrando = false;
            }


        }
    }


}
