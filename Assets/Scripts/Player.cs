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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("TestSecondScene");
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
            if(Input.GetMouseButtonDown(0) && playerItems.currentWater > 0)
            {
                _isWatering = true;
                speed = 0f;
            }
            else if(Input.GetMouseButtonUp(0) || playerItems.currentWater < 0)
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
            if(Input.GetMouseButtonDown(0))
            {
                _isDigging = true;
                speed = 0f;
            }
            else if(Input.GetMouseButtonUp(0))
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
            if(Input.GetMouseButtonDown(0))
            {
                _isCutting = true;
                speed = 0f;
            }
            else if(Input.GetMouseButtonUp(0))
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
    }

    private void OnMove()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);
    }

    private void OnRun()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
            _isRunning = true;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = initialSpeed;
            _isRunning = false;
        }
    }

    private void OnRolling()
    {
        if(Input.GetMouseButtonDown(1))
        {
            speed = runSpeed;
            _isRolling = true;
        }

        if(Input.GetMouseButtonUp(1))
        {
            speed = initialSpeed;
            _isRolling = false;
        }
    }

    #endregion
}
