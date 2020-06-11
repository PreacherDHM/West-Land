using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropedItem : MonoBehaviour
{
    public Item item;
    public Transform Invintory;
    IItemContainer itemContainer;
    

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = item.icon;
        if(Invintory == null)
        {
            Invintory = GameObject.FindGameObjectWithTag("Invintory").transform;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            itemContainer = Invintory.GetComponent<IItemContainer>();
            //print(itemContainer);
            AddItemToInvitory(itemContainer);
            
        }
    }

    public void AddItemToInvitory(IItemContainer container)
    {
        //print("can add item " + container.AddItem(item));
        if (container.AddItem(item))
        {
            Destroy(gameObject);
        }
        
    }
}
