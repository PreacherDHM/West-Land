
using System.Collections.Generic;

public interface IItemContainer
{
    float weight { get; }
    List<Item> ItemsWithTag { get; }
    Item GetItemWithTag(string tag);
    void GetItemsWithTag(string tag);
    int itemCount(Item item);
    bool ContainsItem(Item item);
    bool RemoveItem(Item item);
    bool AddItem(Item item);
    bool isFull();
}
