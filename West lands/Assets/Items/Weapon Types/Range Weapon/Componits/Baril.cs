using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Baril", menuName = "RangWeapon/Baril", order = 0)]
public class Baril : RangeWeaponParts
{
    [Header("Tag: Weapon-Part")]
    public AmmoTypes ammoType;
    [Range(0,1)] public float accuracy;
    public float barilLeanth;
}
