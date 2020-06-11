using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct ItemAmount
{
    public Item item;
    [Range(1, 999)]
    public int amount;
}

[CreateAssetMenu(fileName = "New Crafting Recipe", menuName = "Crafting Recipe", order = 1)]
public class CraftingRecipe : ScriptableObject
{
    public List<ItemAmount> materials;
    public List<ItemAmount> result;

    public bool CanCraft(IItemContainer itemContainer)
    {
        foreach(ItemAmount itemAmount in materials)
        {
            if(itemContainer.itemCount(itemAmount.item) < itemAmount.amount)
            {
                return true;
            }
        }
        return false;
    }
    public void Craft(IItemContainer itemContainer)
    {
        if (CanCraft(itemContainer))
        {
            foreach (ItemAmount itemAmount in materials)
            {
                for (int i = 0; i < itemAmount.amount; i++)
                {
                    itemContainer.RemoveItem(itemAmount.item);
                }
            }
            
            foreach (ItemAmount itemAmount in result)
            {
                for (int i = 0; i < itemAmount.amount; i++)
                {
                    itemContainer.AddItem(itemAmount.item);
                }
            }
        }
    }

}
