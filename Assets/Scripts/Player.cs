using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool isPaused;

    [SerializeField] private float speed;
    [SerializeField] private float runSpeed;

    private Rigidbody2D rig;

    private float initialSpeed;
    private bool _isRunning;
    private bool _isRolling;
    private bool _isCutting;
    private bool _isDigging;
    private bool _isWatering;
    private Vector2 _direction;

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

    public Vector2 direction
    { 
        get { return _direction; }
        set { _direction = value; }
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        playerItems = GetComponent<PlayerItems>();
        initialSpeed = speed;
    }

    private void Update()
    {
        if(!isPaused)
        {
            OnToolChange();
            OnInput();
            OnRun();
            OnRolling();
            OnCutting();
            OnDig();
            OnWatering();
        }
    }

    private void FixedUpdate()
    {
        if(!isPaused)
        {
            OnMove();
        }
    }

    #region Movement

    private void OnWatering()
    {
        if(handlingObj == 2 ){
            if((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1")) && playerItems.currentWater > 0)
            {
                _isWatering = true;
                speed = 0f;
            }
            else if((Input.GetMouseButtonUp(0) || Input.GetButtonUp("Fire1")) || playerItems.currentWater < 0)
            {
                _isWatering = false;
                speed = initialSpeed;
                Debug.Log("Regador vazio!");
            }

            if(_isWatering)
            {
                playerItems.currentWater -= 0.01f;
            }
        }
        else
        {
            _isWatering = false;
        }
    }

    private void OnDig()
    {
        if(handlingObj == 1){
            if((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1")))
            {
                _isDigging = true;
                speed = 0f;
            }
            else if((Input.GetMouseButtonUp(0) || Input.GetButtonUp("Fire1")))
            {
                _isDigging = false;
                speed = initialSpeed;
            }
        }
        else
        {
            _isDigging = false;
        }
    }

    private void OnCutting()
    {
        if(handlingObj == 0){
            if((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1")))
            {
                _isCutting = true;
                speed = 0f;
            }
            else if((Input.GetMouseButtonUp(0) || Input.GetButtonUp("Fire1")))
            {
                _isCutting = false;
                speed = initialSpeed;
            }
        }
        else
        {
            _isCutting = false;
        }
    }

    private void OnInput()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void OnToolChange()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            handlingObj = 0;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            handlingObj = 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            handlingObj = 2;
        }

        // Controle via joystick
        if (Input.GetButtonDown("JoystickR"))
        {
            handlingObj = (handlingObj + 1) % 3; // Incrementa e faz wrap-around de 0 a 2
        }
        if (Input.GetButtonDown("JoystickL"))
        {
            handlingObj = (handlingObj == 0) ? 2 : handlingObj - 1; // Decrementa e faz wrap-around de 0 a 2
        }
    }

    private void OnMove()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);
    }

    private void OnRun()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetButtonDown("Fire2"))
        {
            speed = runSpeed;
            _isRunning = true;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetButtonUp("Fire2"))
        {
            speed = initialSpeed;
            _isRunning = false;
        }
    }

    private void OnRolling()
    {
        if(Input.GetMouseButtonDown(1) || Input.GetButtonDown("Fire3"))
        {
            speed = runSpeed;
            _isRolling = true;
        }

        if(Input.GetMouseButtonUp(1) || Input.GetButtonUp("Fire3"))
        {
            speed = initialSpeed;
            _isRolling = false;
        }
    }

    #endregion
}
