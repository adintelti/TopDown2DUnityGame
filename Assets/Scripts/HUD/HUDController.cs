using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [Header("Items")]
    [SerializeField] private Image waterUIBar;
    [SerializeField] private Image woodUIBar;
    [SerializeField] private Image carrotUIBar;
    [SerializeField] private Image fishUIBar;

    [Header("Tools")]
    public List<Image> toolsUI = new List<Image>();
    [SerializeField] private Color selectedColor;
    [SerializeField] private Color UnselectedColor;

    [Header("Money")]
    [SerializeField] private Text CashUIText;

    private PlayerItems playerInventory;
    private Player player;

    private void Awake()
    {
        playerInventory = FindObjectOfType<PlayerItems>();
        player = playerInventory.GetComponent<Player>();
    }

    void Start()
    {
        waterUIBar.fillAmount = 0f;
        woodUIBar.fillAmount = 0f;
        carrotUIBar.fillAmount = 0f;
        fishUIBar.fillAmount = 0f;
        CashUIText.text = "000";
    }

    void Update()
    {
        waterUIBar.fillAmount = playerInventory.currentWater / playerInventory.maxWater;
        woodUIBar.fillAmount = playerInventory.currentWood / playerInventory.maxWood;
        carrotUIBar.fillAmount = playerInventory.currentCarrot / playerInventory.maxCarrot;
        fishUIBar.fillAmount = playerInventory.currentFishes / playerInventory.maxFish;
        CashUIText.text = playerInventory.currentCash.ToString("000.00");;

        for (var i = 0; i < toolsUI.Count; i++)
        {
            if(i == player.handlingObj)
            {
                toolsUI[i].color = selectedColor;
            }
            else
            {
                toolsUI[i].color = UnselectedColor;
            }
        }
    }
}
