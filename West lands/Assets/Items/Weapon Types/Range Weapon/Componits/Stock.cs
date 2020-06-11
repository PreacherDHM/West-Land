using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]


[CreateAssetMenu(fileName ="New Stock",menuName = "RangWeapon/Stock", order = 0)]
public class Stock : RangeWeaponParts
{
    public StockType stock;
}
