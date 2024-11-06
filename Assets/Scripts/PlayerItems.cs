using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    [Header("Items in Inventory")]
    public float currentWood;
    public float currentWater;
    public float currentCarrot;
    public float currentFishes;
    public float currentCash;

    [Header("Capacity")]
    public int maxWood;
    public int maxWater;
    public int maxCarrot;
    public int maxFish;
    public int maxCash;

    public void AddWater(int water)
    {
        if(currentWater < maxWater)
        {
            currentWater += water;
        }
        else
        {
            Debug.Log("Regador cheio de água!");
        }
    }

    public void AddWood(int wood)
    {
        if(CollectWood())
        {
            currentWood += wood;
        }
        else
        {
            Debug.Log("Inventário cheio de madeira!");
        }
    }

    public bool CollectWood()
    {
        return currentWood < maxWood;
    }

    public void AddCarrot(int carrot)
    {
        if(CollectCarrot())
        {
            currentCarrot += carrot;
        }
        else
        {
            Debug.Log("Inventário cheio de cenouras!");
        }
    }

    public bool CollectCarrot()
    {
        return currentCarrot < maxCarrot;
    }

    public void AddFish(int fish)
    {
        if(CollectFish())
        {
            currentFishes += fish;
        }
        else
        {
            Debug.Log("Inventário cheio de peixes!");
        }
    }

    public bool CollectFish()
    {
        return currentFishes < maxFish;
    }

    public void AddCash(int cash)
    {
        if(CollectCash())
        {
            currentCash += cash;
        }
        else
        {
            Debug.Log("Carteira lotada!");
        }
    }

    public bool CollectCash()
    {
        return currentCash < maxCash;
    }
}
