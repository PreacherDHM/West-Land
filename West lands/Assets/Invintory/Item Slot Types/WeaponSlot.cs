using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : ItemSlotBase
{
    public string[] alowedTags;
    

    public override bool CheckTag(string[] Tags)
    {
        for (int i = 0; i < Tags.Length; i++)
        {
            for (int p = 0; p < alowedTags.Length; p++)
            {
                if (Tags[i] == alowedTags[p])
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
        
        if (_Item is RangeWeapon)
        {
            return _Item;
        }
        return null;
    }

    public override void RemoveItem()
    {
        throw new System.NotImplementedException();
    }

    public override void SlotInit()
    {

    }
}
