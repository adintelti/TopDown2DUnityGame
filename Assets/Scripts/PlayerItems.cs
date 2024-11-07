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

    [Header("Shop Prices")]
    public int buyWoodPrice;
    public int buyCarrotPrice;
    public int buyFishPrice;
    public int sellWoodPrice;
    public int sellCarrotPrice;
    public int sellFishPrice;

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

    public void BuyWood()
    {
        if(CollectWood())
        {
            if(buyWoodPrice <= currentCash)
            {
                AddWood(1);
                AddCash(buyWoodPrice * -1);
            }
            else
            {
                Debug.Log("Não tem dinheiro suficiente!");
            }
        }
        else
        {
            Debug.Log("Não é possível comprar, Inventário cheio de madeira!");
        }
    }

    public void SellWood()
    {
        if(currentWood > 0)
        {
                AddCash(sellWoodPrice);
                currentWood--;
        }
        else
        {
            Debug.Log("Não é possível vender, Inventário sem madeiras!");
        }
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

    public void BuyCarrot()
    {
        if(CollectCarrot())
        {
            if(buyCarrotPrice <= currentCash)
            {
                AddCarrot(1);
                AddCash(buyCarrotPrice * -1);
            }
            else
            {
                Debug.Log("Não tem dinheiro suficiente!");
            }
        }
        else
        {
            Debug.Log("Não é possível comprar, Inventário cheio de cenouras!");
        }
    }

    public void SellCarrot()
    {
        if(currentCarrot > 0)
        {
                AddCash(sellCarrotPrice);
                currentCarrot--;
        }
        else
        {
            Debug.Log("Não é possível vender, Inventário sem cenouras!");
        }
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

    public void BuyFish()
    {
        if(CollectFish())
        {
            if(buyFishPrice <= currentCash)
            {
                AddFish(1);
                AddCash(buyFishPrice * -1);
            }
            else
            {
                Debug.Log("Não tem dinheiro suficiente!");
            }
        }
        else
        {
            Debug.Log("Não é possível comprar, Inventário cheio de peixes!");
        }
    }

    public void SellFish()
    {
        if(currentFishes > 0)
        {
                AddCash(sellFishPrice);
                currentFishes--;
        }
        else
        {
            Debug.Log("Não é possível vender, Inventário sem peixes!");
        }
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
