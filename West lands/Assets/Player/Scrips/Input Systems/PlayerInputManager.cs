using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour, IMovementInput, IInvintoryInput
{
    public PlayerControls PlayerAction;

    private bool IsInvintoryOpen;

    public Vector2 MoveDirection { get; private set; }
    public bool isSprinting { get; private set; }

    public bool OpenInvintory { get; set; }

    private void Awake()
    {
        PlayerAction = new PlayerControls();
    }

    private void OnDisable()
    {
        PlayerAction.Player.Disable();

    }

    private void OnEnable()
    {
        PlayerAction.Player.Invintory.performed += OnInvintory;
        PlayerAction.Player.Move.performed += OnMovementAction;
        PlayerAction.Player.Sprint.performed += OnSprint;
        PlayerAction.Player.Doge.performed += OnDoge;
        PlayerAction.Player.Enable();
        
    }

    private void OnDoge(InputAction.CallbackContext obj)
    {
        
    }



    private void OnSprint(InputAction.CallbackContext obj)
    {
        //Debug.Log(obj.phase);
        if (obj.performed)
        {
            
            isSprinting ^= true;
        }




    }



    private void OnInvintory(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            print("Open Invinoty");
            OpenInvintory ^= true;
        }
    }

    private void OnMovementAction(InputAction.CallbackContext obj)
    {
        Vector2 value = obj.ReadValue<Vector2>();
        //Debug.Log(value);
        MoveDirection = value; 
    }

    public void isDashing()
    {
        throw new NotImplementedException();
    }
}
