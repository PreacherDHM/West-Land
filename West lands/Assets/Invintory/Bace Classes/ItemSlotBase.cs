using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public abstract class ItemSlotBase : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] GameObject ItemUI;
    [SerializeField] Text displayName;
    [SerializeField] Item _item;
    [SerializeField] RectTransform InfoPanlePos;
    [SerializeField] GameObject InfoPanle;
    [SerializeField] Canvas canvas;
    public Item Item
    {
        get { return GetItem(_item); }
        set
        {


            _item = value;

            if (_item == null)
            {
                print("no item");
                InfoPanle.gameObject.SetActive(false);
            }
            else
            {

                if (_item.itemName == "")
                {
                    displayName.text = "this item needs a name";
                }
                else
                {
                    displayName.text = _item.itemName;

                }


            }
        }
    }


    abstract public void SlotInit();
    abstract public void RemoveItem();
    abstract public Item GetItem(Item _Item);

    abstract public bool CheckTag(string[] Tags);

    public bool SetItem(Item _Item)
    {
        if (transform.Find("Item Data") == null)
        {
            Instantiate(ItemUI, transform);
            GetComponentInChildren<ItemData>().Item = _Item;
            GetComponentInChildren<ItemData>().canvas = canvas;
            Item = GetComponentInChildren<ItemData>().Item;


            return true;
        }
        else
        {
            return false;
        }
    }
    

    public void Start()
    {
        SlotInit();
        InfoPanle.GetComponent<RectTransform>().position = InfoPanlePos.position;

        
    }


    public void OnDrop(PointerEventData eventData)
    {

        print("item Droped in Slot");
        if(Item == null && CheckTag(eventData.pointerDrag.GetComponent<ItemData>().Item.Tags))
        {
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = transform.GetComponent<RectTransform>().position;
            Item = GetComponentInChildren<ItemData>().Item;
        }



    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(Item != null)
        {
            InfoPanle.GetComponent<RectTransform>().position = InfoPanlePos.position;
            InfoPanle.gameObject.SetActive(true);
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (Item != null)
        {
            InfoPanle.GetComponent<RectTransform>().position = InfoPanlePos.position;
            InfoPanle.gameObject.SetActive(false);
        }
            
    }
}
