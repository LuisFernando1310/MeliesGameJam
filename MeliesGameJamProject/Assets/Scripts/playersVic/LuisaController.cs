using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuisaController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public bool andando;
    public bool empurrando;

    public Animator animator;
    public Animator animBotaoGrande;
    public BarraMedoo scriptbarramedo;

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
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0);

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

        if (Input.GetKey(KeyCode.RightControl))
        {
            empurrando = true;
            animator.SetBool("empurra", true);
        }
        else
        {
            animator.SetBool("empurra", false);
            empurrando = false;
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


}
