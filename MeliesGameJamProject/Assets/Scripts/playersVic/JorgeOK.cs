﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgeOK : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 5f;
    public bool andandoJ;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Animator animator;
    public bool poderAtivado;
    public Animator animBotaoGrande;

    public GameObject[] Cruz;

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        TocaAnimacao();
    }

    void Movimentacao()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            andandoJ = true;
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0);

            controller.Move(direction * speed * Time.deltaTime);
        }
        else
        {
            andandoJ = false;
        }
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

        }
        else
        {
            animator.SetBool("poder", false);
            poderAtivado = false;
        }
    }

  

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "botaoG" && poderAtivado == true)
        {
                animBotaoGrande.speed = 0;   
        }

        if((other.tag == "CruzTorta" && poderAtivado == true))
        {
            Destroy(other.gameObject);
        }
    }
}
