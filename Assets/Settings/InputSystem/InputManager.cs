using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public bool PauseOpenAndCloceInput { get; private set; }
    private PlayerInput _playerInput;
    private InputAction _pauseOpenaAndCloseAction;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        _playerInput = GetComponent<PlayerInput>();
        _pauseOpenaAndCloseAction = _playerInput.actions["Pause (Open & Close)"];
        
    }

    // Update is called once per frame
    void Update()
    {
        PauseOpenAndCloceInput = _pauseOpenaAndCloseAction.WasPressedThisFrame();
    }
}
