using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditscamera : MonoBehaviour
{
    public Animator animator;
    public Animation anim;


    public void Volta()
    {
        animator.SetTrigger("voltacamera");
    }

    public void Vai()
    {
        animator.SetTrigger("vaidenovo");
    }

}
