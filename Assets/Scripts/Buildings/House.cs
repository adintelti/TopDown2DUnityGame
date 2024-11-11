using UnityEngine;
using UnityEngine.InputSystem;
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
    }

    public void Interact(InputAction.CallbackContext value)
    {
        if (detectingPlayer && value.started && playerInventory.currentWood >= woodAmount && playerInventory.currentCash >= cashAmount && !houseCreated)
        {
            buildStarted = true;
            playerAnim.OnHammeringStarted();
            houseSprite.color = startColor;
            player.transform.position = point.position;
            player.isPaused = true;
            playerInventory.currentCash -= woodAmount * -1;
            playerInventory.currentWood -= cashAmount * -1;
        }

        if (houseCreated && detectingPlayer && value.started)
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
