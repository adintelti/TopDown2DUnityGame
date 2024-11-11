using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public bool isPaused;
    public Vector2 movement;

    [SerializeField] private float speed;
    [SerializeField] private float runSpeed;

    private Rigidbody2D rig;

    private float initialSpeed;
    private bool _isRunning;
    private bool _isRolling;
    private bool _isCutting;
    private bool _isDigging;
    private bool _isWatering;

    [HideInInspector]public int handlingObj;
    private PlayerItems playerItems;

    public bool isRunning
    { 
        get { return _isRunning; }
        set { _isRunning = value; }
    }

    public bool isRolling
    { 
        get { return _isRolling; }
        set { _isRolling = value; }
    }

    public bool isCutting
    { 
        get { return _isCutting; }
        set { _isCutting = value; }
    }

    public bool isDigging
    { 
        get { return _isDigging; }
        set { _isDigging = value; }
    }

    public bool isWatering
    { 
        get { return _isWatering; }
        set { _isWatering = value; }
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        playerItems = GetComponent<PlayerItems>();
        initialSpeed = speed;
    }

    private void FixedUpdate()
    {
        if(!isPaused)
        {
            OnMove();
        }
    }

    public void Move(InputAction.CallbackContext value)
    {
        if (!isPaused)
        {
            movement = value.ReadValue<Vector2>();
        }
    }

    #region Movement

    public void Action(InputAction.CallbackContext value)
    {
        if (!isPaused && (value.started || value.performed))
        {
            if(handlingObj == 0)
            {
                _isCutting = true;
                speed = 0f;
            }
            else
            {
                _isCutting = false;
            }

            if (handlingObj == 1)
            {
                _isDigging = true;
                speed = 0f;
            }
            else
            {
                _isDigging = false;
            }

            if (handlingObj == 2)
            {
                if (playerItems.currentWater > 0)
                {
                    _isWatering = true;
                    speed = 0f;
                }
                else if (playerItems.currentWater < 0)
                {
                    _isWatering = false;
                    speed = initialSpeed;
                    Debug.Log("Regador vazio!");
                }
                else
                {
                    _isWatering = false;
                }
            }
        }

        if (value.canceled)
        {
            if(handlingObj == 0)
            {
                _isCutting = false;
                speed = initialSpeed;
            }

            if (handlingObj == 1)
            {
                _isDigging = false;
                speed = initialSpeed;
            }

            if(handlingObj == 2)
            {
                _isWatering = false;
                speed = initialSpeed;
                Debug.Log("Parou de regar!");
            }
        }
    }

    //private void OnInput()
    //{
    //    movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    //}

    public void SelectAxeByKeyBoard(InputAction.CallbackContext value)
    {
        if(!isPaused && value.started)
        {
            handlingObj = 0;
        }
    }

    public void SelectShovelByKeyBoard(InputAction.CallbackContext value)
    {
        if (!isPaused && value.started)
        {
            handlingObj = 1;
        }
    }

    public void SelectWaterCanByKeyBoard(InputAction.CallbackContext value)
    {
        if (!isPaused && value.started)
        {
            handlingObj = 2;
        }
    }

    public void IncreaseToolSelection(InputAction.CallbackContext value)
    {
        if (!isPaused && value.started)
        {
            handlingObj = (handlingObj + 1) % 3; // Incrementa e faz wrap-around de 0 a 2
        }
    }

    public void DecreaseToolSelection(InputAction.CallbackContext value)
    {
        if (!isPaused && value.started)
        {
            handlingObj = (handlingObj == 0) ? 2 : handlingObj - 1; // Decrementa e faz wrap-around de 0 a 2
        }
    }

    private void OnMove()
    {
        rig.MovePosition(rig.position + movement * speed * Time.fixedDeltaTime);
    }

    public void Run(InputAction.CallbackContext value)
    {
        if (!isPaused && value.started)
        {
            speed = runSpeed;
            _isRunning = true;
        }
        if(value.canceled)
        {
            speed = initialSpeed;
            _isRunning = false;
        }
    }

    public void Roll(InputAction.CallbackContext value)
    {
        if(!isPaused && (value.started || value.performed))
        {
            speed = runSpeed;
            _isRolling = true;
        }

        if(value.canceled)
        {
            speed = initialSpeed;
            _isRolling = false;
        }
    }

    #endregion
}
