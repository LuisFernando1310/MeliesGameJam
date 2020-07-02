using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgeOK : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0);

            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
