using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgeController : MonoBehaviour
{
    public float speed = 20;
    private Vector3 pos;
    private Vector3 direction;
    public bool poderAtivado = false;

    private void Start()
    {
       

    }

    void Update()
    {

        Movimentacao();
        AtivaPoder();
    }

    void AtivaPoder()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            poderAtivado = true;
        }

        
    }

    void Movimentacao()
    {
        pos = transform.position;
        pos.x += speed * Input.GetAxis("Horizontal2") * Time.deltaTime;
        pos.z += speed * Input.GetAxis("Vertical2") * Time.deltaTime;
        transform.position = pos;
        //Quaternion target = Quaternion.Euler(pos.x, 0, pos.z);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);
    }
}
