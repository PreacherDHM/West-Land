using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food Item", menuName = "Food Item")]
public class Food : ScriptableObject
{
    [Range(0,5)]
    public int rarity;
    public string FoodTags;
    [Range(0,200)]
    [Tooltip("This is in seconds")]
    public float cookingTime;
    [Space]
    public float Health;
    public float stamina;

}
