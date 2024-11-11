using UnityEngine;
using UnityEngine.InputSystem;

public class Casting : MonoBehaviour
{
    [SerializeField] private bool detectingPlayer;
    [SerializeField] private int sucessRate;
    [SerializeField] private GameObject fishPrefab;

    private PlayerItems playerInventory;
    private PlayerAnim playerAnim;

    void Start()
    {
        playerInventory = FindObjectOfType<PlayerItems>();
        playerAnim = playerInventory.GetComponent<PlayerAnim>();
    }

    public void Interact(InputAction.CallbackContext value)
    {
        if (detectingPlayer && value.started)
        {
            playerAnim.OnCastingStarted();
        }
    }

    public void OnCasting()
    {
        int randomValue = Random.Range(1, 100);

        if(randomValue <= sucessRate)
        {
            Instantiate(fishPrefab, playerInventory.transform.position + new Vector3(Random.Range(-2f, -1f), 0f, 0f), Quaternion.identity);
            Debug.Log("Pescou");
        }
        else
        {
            Debug.Log("Não Pescou");
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
