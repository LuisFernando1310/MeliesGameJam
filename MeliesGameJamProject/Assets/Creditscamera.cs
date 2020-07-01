using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditscamera : MonoBehaviour
{
    public Animation anim;
   

    public void CameraVai()
    {
        anim.Play("CameraCredits");
    }
}
