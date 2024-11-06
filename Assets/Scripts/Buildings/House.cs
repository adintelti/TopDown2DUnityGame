using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [Header("Amounts")]
    [SerializeField] private int woodAmount;
    [SerializeField] private int cashAmount;
    [SerializeField] private float timeToBuild;

    [Header("Collor change")]
    [SerializeField] private Color startColor;
    [SerializeField] private Color endColor;

    [Header("Elements")]
    [SerializeField] private GameObject houseColl;
    [SerializeField] private SpriteRenderer houseSprite;
    [SerializeField] private Transform point;

    private bool detectingPlayer;
    private Player player;
    private PlayerItems playerInventory;
    private PlayerAnim playerAnim;

    private float elipsedTime;
    private bool buildStarted;

    void Start()
    {
        player = FindObjectOfType<Player>();
        playerInventory = player.GetComponent<PlayerItems>();
        playerAnim = player.GetComponent<PlayerAnim>();
    }

    void Update()
    {
        if(detectingPlayer && Input.GetKeyDown(KeyCode.E) && playerInventory.currentWood >= woodAmount && playerInventory.currentCash >= cashAmount)
        {
            buildStarted = true;
            playerAnim.OnHammeringStarted();
            houseSprite.color = startColor;
            player.transform.position = point.position;
            player.isPaused = true;
            playerInventory.AddWood(woodAmount * -1);
            playerInventory.AddCash(cashAmount * -1);
        }

        if(buildStarted)
        {
            elipsedTime += Time.deltaTime;

            if(elipsedTime >= timeToBuild)
            {
                //casa terminada
                playerAnim.OnHammeringEnded();
                houseSprite.color = endColor;
                player.isPaused = false;
                houseColl.SetActive(true);
            }
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
