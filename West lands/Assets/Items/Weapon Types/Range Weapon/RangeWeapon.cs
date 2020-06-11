using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Range Weapon", menuName = "Range Weapon")]
public class RangeWeapon : Item
{
    public WeaponType weaponType;
    public AmmoTypes ammoType;
    [Space]
    public List<Attachments> attachments;
    public Upper upper;
    public Lower lower;
    public Baril baril;
    public Stock stock;
    public Magazine magazine;
    

}
