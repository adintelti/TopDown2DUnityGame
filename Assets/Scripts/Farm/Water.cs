using UnityEngine;
using UnityEngine.InputSystem;

public class Water : MonoBehaviour
{
    [SerializeField] private bool detectingPlayer;
    private PlayerItems playerInventory;

    void Start()
    {
        playerInventory = FindObjectOfType<PlayerItems>();
    }
	
	public void Interact(InputAction.CallbackContext value)
    {
        if(value.started && detectingPlayer) 
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
