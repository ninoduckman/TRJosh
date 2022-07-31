using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls inputActions;

    public Vector2 cameraInput;
    public float Scroll;
    public bool isClicking;
    public Vector2 mousePos;
    void OnEnable()
    {
        if(inputActions == null)
        {
            inputActions = new PlayerControls();
            inputActions.CamMovement.Move.performed += inputActions => cameraInput = inputActions.ReadValue<Vector2>();
            inputActions.CamMovement.MousePos.performed += inputActions => mousePos = inputActions.ReadValue<Vector2>();
            inputActions.CamMovement.Zoom.performed += inputActions => Scroll = inputActions.ReadValue<float>();
            inputActions.CamMovement.Click.performed += inputActions => isClicking = true;
            inputActions.CamMovement.Click.canceled += inputActions => isClicking = false;

        }
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
