using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class DetectController : MonoBehaviour
{
    PlayerInput playerInput;
    string currentControlName = "";

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.onActionTriggered += (CallbackContext ctx) =>
        {
            LogCurrentlyUsedDevice();
            Debug.Log("ACTION PERFORMED IS: " + ctx.action.name);
        };
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LogCurrentlyUsedDevice()
    {
        if (playerInput.currentControlScheme == "Gamepad")
        {
            currentControlName = Gamepad.current.name;
        }
        else if (playerInput.currentControlScheme == "Keyboard&Mouse")
        {
            currentControlName = Keyboard.current.name;
        }
        Debug.Log("CURRENT ACTIVE CONTROLLER IS: " + currentControlName);
    }
}
