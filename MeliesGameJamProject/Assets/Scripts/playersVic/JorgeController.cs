using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgeController : MonoBehaviour
{
    public float speed = 20;
    private Vector3 pos;

    private void Start()
    {

    }

    void Update()
    {

        pos = transform.position;
        pos.x += speed * Input.GetAxis("Horizontal2") * Time.deltaTime;
        pos.z += speed * Input.GetAxis("Vertical2") * Time.deltaTime;
        transform.position = pos;
    }
}
