using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : ItemSlotBase
{
    [SerializeField] Text ItemTags;

    public override void SlotInit() { }


    public override bool CheckTag(string[] Tags)
    {
        return true;
    }

    public override void RemoveItem()
    {
        throw new NotImplementedException();
    }

    public override Item GetItem(Item _Item)
    {
        return (_Item);
    }
}
