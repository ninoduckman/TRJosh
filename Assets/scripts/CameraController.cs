using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    InputManager inputManager;
    
    public float movementSpeed;
    public float movementTime;
    public float scrollspeed;

    public Vector2 maxminHeight;

    private float scroll;

    public Transform cam;
    
    public Vector3 newPosition;
    [SerializeField] Vector2 camMovement;

    void Start()
    {
        newPosition = transform.position;

        inputManager = GetComponent<InputManager>();
    }

    void Update()
    {
        HandleZoom();
        HandleMovementInput();
    }
    void HandleZoom()
    {
        scroll = inputManager.Scroll * scrollspeed;
        if(scroll < 0 && transform.position.y < 15f)
        {
            newPosition -= cam.forward;
        }
        else if(scroll > 0 && transform.position.y > 10f)
        {
            newPosition += cam.forward;
        }
    }
    void HandleMovementInput()
    {
        camMovement = inputManager.cameraInput;

        newPosition = new Vector3(newPosition.x + (camMovement.x * Time.deltaTime * movementSpeed * (newPosition.y/13)), newPosition.y, newPosition.z + (camMovement.y * Time.deltaTime * movementSpeed * (newPosition.y/10)));

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * (movementTime));
    }

    
}
