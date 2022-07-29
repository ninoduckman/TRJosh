using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float movementSpeed;
    public float movementTime;


    public Vector3 newPosition;

    void Start()
    {
        newPosition = transform.position;
        movementSpeed /= 100;
    }

    void Update()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        //nota: cambiar por inputsystem
        if(Input.GetKey(KeyCode.W))
        {
            newPosition += (transform.forward * movementSpeed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            newPosition += (transform.forward * -movementSpeed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            newPosition += (transform.right * -movementSpeed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            newPosition += (transform.right * movementSpeed);
        }
        newPosition.y = 10;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * (movementTime));
    }
}
