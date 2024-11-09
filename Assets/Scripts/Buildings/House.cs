using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private bool houseCreated;

    void Start()
    {
        player = FindObjectOfType<Player>();
        playerInventory = player.GetComponent<PlayerItems>();
        playerAnim = player.GetComponent<PlayerAnim>();
    }

    void Update()
    {
        if(detectingPlayer && (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire4")) && playerInventory.currentWood >= woodAmount && playerInventory.currentCash >= cashAmount && !houseCreated)
        {
            buildStarted = true;
            playerAnim.OnHammeringStarted();
            houseSprite.color = startColor;
            player.transform.position = point.position;
            player.isPaused = true;
            playerInventory.currentCash -= woodAmount * -1;
            playerInventory.currentWood -= cashAmount * -1;
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
                houseCreated = true;
            }
        }

        if(houseCreated && detectingPlayer && (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire4")))
        {
            SceneManager.LoadScene("TestSecondScene");
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
