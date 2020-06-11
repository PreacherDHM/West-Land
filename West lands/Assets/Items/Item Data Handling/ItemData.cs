using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemData : MonoBehaviour  ,IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] CanvasGroup canvasGroup;
    public Canvas canvas;
    public Item Item;


    private void Awake()
    {
        

        
    }
    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        GetComponent<Image>().sprite = Item.icon;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        GetComponentInParent<ItemSlotBase>().Item = null;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("drop");
        eventData.pointerDrag.GetComponent<RectTransform>().position = eventData.pointerDrag.transform.parent.GetComponent<RectTransform>().position;
        eventData.pointerDrag.transform.parent.GetComponent<ItemSlotBase>().Item = Item;
        canvasGroup.blocksRaycasts = true;

    }

    public void OnDrag(PointerEventData eventData)
    {

            GetComponent<RectTransform>().anchoredPosition += eventData.delta / canvas.scaleFactor;
        

    }
}
