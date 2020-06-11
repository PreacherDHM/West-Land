using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invintory : MonoBehaviour, IItemContainer
{
    public string[] ItemTags { get; private set; }
    public float weight { get; private set; }

    public List<Item> ItemsWithTag { get; private set; }

    [SerializeField] int itemSlotAmount;
    [SerializeField] float maxWeight;
    [SerializeField] List<Item> items;
    [SerializeField] Transform itemSlotsParint;
    [SerializeField] GameObject UIitemSlotTemplate;
    [SerializeField] ItemSlot[] itemSlot;



    private void Awake()
    {

        if (itemSlot != null)
        {
            if(itemSlotsParint.childCount == itemSlotAmount)
            {
                

            }else if (itemSlotsParint.childCount < itemSlotAmount)
            {
                for (int i = itemSlotsParint.childCount; i < itemSlotAmount; i++)
                {
                    Instantiate(UIitemSlotTemplate, itemSlotsParint);
                    
                }

                
            }
            else if(itemSlotsParint.childCount > itemSlotAmount)
            {
                
                for (int i = itemSlotAmount; i < itemSlotsParint.childCount; i++)
                {
                    Destroy(itemSlotsParint.GetChild(i).gameObject);
                }
            }
            itemSlot = itemSlotsParint.GetComponentsInChildren<ItemSlot>();
        }
        RefreshUI();
    }

    private void RefreshUI()
    {
        int i = 0;
        for (; i < items.Count && i < itemSlot.Length; i++)
        {
            itemSlot[i].SetItem(items[i]);
            
        }
        for (; i < itemSlot.Length; i++)
        {

            //itemSlot[i].SetItem(null);
        }

    }

    public bool AddItem(Item item)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            
            if (itemSlot[i].Item == null && weight < maxWeight && itemSlot[i].SetItem(item))
            {
                
                weight += item.weight;
                return true;
            }

            
        }
        
        return false;
    }

    public bool ContainsItem(Item item)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if(itemSlot[i].Item == item)
            {
                return true;
            }
        }
        return false;
    }

    public bool isFull()
    {
        
        for(int i = 0; i < itemSlot.Length; i++)
        {
            
            if (itemSlot[i].Item == null && weight < maxWeight)
            {

                return false;
            }

        }
        return true;
    }

    public int itemCount(Item item)
    {
        int tulotulItems = 0;
        for(int i = 0; i < itemSlot.Length; i++)
        {
            if(itemSlot[i].Item == item)
            {
                tulotulItems++;
            }
        }
        return tulotulItems;
    }

    public bool RemoveItem(Item item)
    {
        for(int i = 0; i < itemSlot.Length; i++)
        {
            if(itemSlot[i].Item == item)
            {
                itemSlot[i].SetItem(null);
                weight -= item.weight;
                ItemTags = null;
                return true;
            }
        }
        return false;
    }

    public Item GetItemWithTag(string tag)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            for (int p = 0; p < itemSlot[i].Item.Tags.Length; p++)
            {
                if (itemSlot[i].Item.Tags[p] == tag)
                {
                    return itemSlot[i].Item;
                }
            }

        }
        return null;
    }

    public void GetItemsWithTag(string tag)
    {
        List<Item> getItemsWithTagList = new List<Item>();


        for (int i = 0; i < itemSlot.Length; i++)
        {
            for (int p = 0; p < itemSlot[i].Item.Tags.Length ; p++)
            {
                if (itemSlot[i].Item.Tags[p] == tag)
                {
                    print(itemSlot[i].Item + " in slot " + i);
                }
            }

        }
        //print(getItemsWithTagList.Count);
        ItemsWithTag = getItemsWithTagList;
    }
}
