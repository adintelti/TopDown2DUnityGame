using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotFarm : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _holeSFX;
    [SerializeField] private AudioClip _carrotSFX;

    [Header("Components")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite hole;
    [SerializeField] private Sprite carrot;

    [Header("Settings")]
    [SerializeField] private int digAmount;
    [SerializeField] private float waterAmount;

    [SerializeField] private bool detectingWater;

    private int initialDigAmount;
    private float currentWaterInSlot;
    private bool dugHole;
    private bool plantedCarrot;

    PlayerItems playerInventory;

    void Start()
    {
        playerInventory = FindObjectOfType<PlayerItems>();
        initialDigAmount = digAmount;
    }

    void Update()
    {
        if(dugHole)
        {
            if(detectingWater)
            {
                currentWaterInSlot += 0.01f;
            }

            //encheu o total de água necessário
            if(currentWaterInSlot >= waterAmount && !plantedCarrot)
            {
                _audioSource.PlayOneShot(_holeSFX);
                spriteRenderer.sprite = carrot;

                plantedCarrot = true;
            }

            if(Input.GetKeyDown(KeyCode.E) && plantedCarrot)
            {
                playerInventory.AddCarrot(1);
                if(playerInventory.CollectCarrot())
                {
                    _audioSource.PlayOneShot(_carrotSFX);
                    spriteRenderer.sprite = hole;
                    currentWaterInSlot = 0;
                }
            }
        }
    }

    public void OnHit()
    {
        digAmount--;

        if(digAmount <= initialDigAmount / 2)
        {
            //Aparece o buraco
            spriteRenderer.sprite = hole;
            dugHole = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Shovel"))
        {
            OnHit();
        }

        if(collision.CompareTag("Water"))
        {
            detectingWater = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Water"))
        {
            detectingWater = false;
        }
    }
}
