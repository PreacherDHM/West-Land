using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName ="Item",order = 2)]
public class Item : ScriptableObject
{
    //Itam ayrubuts
    [Header("Item")]
    public string itemName;
    [Space]
    public Sprite icon;
    [Space]
    [Tooltip("this is how much the part weighs in LBS.")]
    public float weight;
    [Tooltip("this is the rarity of the item being droped")]
    [Range(0,5)]
    public int rarity;
    [Space]
    public string[] Tags;


}
