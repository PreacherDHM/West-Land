using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Magazine", menuName = "RangWeapon/Magazine")]
public class Magazine : Item
{
    public AmmoTypes ammoType;
    public MagazineType magazineType;
    [Space]
    public int ammoAmount;
    [Range(0, 999)]
    public float reloadTime;
}
