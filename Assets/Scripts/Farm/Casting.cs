using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Update()
    {
        if(detectingPlayer && Input.GetKeyDown(KeyCode.E))
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
