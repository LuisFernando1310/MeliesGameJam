using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 5f;

    [SerializeField]
    int playerIndex = 0;

    private CharacterController controller;

    Vector3 moveDirection = Vector3.zero;
    Vector2 inputVector = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    public void SetInputVector(Vector2 direction)
    {
        inputVector = direction;
    }

    private void Update()
    {
        moveDirection = new Vector3(inputVector.x, 0, inputVector.y);
        moveDirection = transform.TransformDirection(moveDirection);

        controller.Move(moveDirection * MoveSpeed * Time.deltaTime);
    }
}
