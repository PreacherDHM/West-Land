using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangeWeaponCraftingSlot : ItemSlotBase
{
    [SerializeField] string[] alowedTags;

    public override bool CheckTag(string[] Tags)
    {
        for (int i = 0; i < Tags.Length; i++)
        {
            for (int p = 0; p < alowedTags.Length; p++)
            {
                if(Tags[i] == alowedTags[p])
                {
                    print(Tags[i] + " : " + alowedTags[p]);
                    return true;
                }
            }
        }
        return false;
    }

    public override Item GetItem(Item _Item)
    {
        return _Item;
    }

    public override void RemoveItem()
    {
        print("test");
        Destroy(transform.GetChild(1).gameObject);
    }

    public override void SlotInit()
    {
        
    }

}
