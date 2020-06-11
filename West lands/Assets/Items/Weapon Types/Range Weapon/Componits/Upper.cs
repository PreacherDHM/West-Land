using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Upper", menuName ="Upper")]
public class Upper : RangeWeaponParts
{
    
    public float barilMinSize;
    public float barilMaxSize;
    [Space]
    [Range(0, 3)] public int upperRaleMountSize;
    [Range(0, 3)] public int lowerRaleMountSize;
    [Space]

    [Range(0, 1)] public float JamAmount;
    

    
}
