using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private bool detectingPlayer;
    private PlayerItems playerInventory;

    void Start()
    {
        playerInventory = FindObjectOfType<PlayerItems>();
    }

    void Update()
    {
        if(detectingPlayer && (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire4")))
        {
            playerInventory.AddWater(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            detectingPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            detectingPlayer = false;
        }
    }
}
