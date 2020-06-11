using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Range Weapon Recipe",menuName = "Recipe/New Range Weapon Recipe")]
public class RangeWeaponRecipe : ScriptableObject
{
    [SerializeField] RangeWeapon Weapon;

    public bool CanCraft(List<RangeWeaponParts> WeaponParts)
    {
        GetWeaponType getWeaponType = new GetWeaponType();
        RangeWeaponParts BacePart = null;


        foreach (var part in WeaponParts)
        {
            if(part is Upper)
            {
                BacePart = part;
                break;
            }
        }


        foreach (var part in WeaponParts)
        {
            if(!getWeaponType.Type(BacePart.weaponList, BacePart.ammoType, part))
            {
                return false;
            }
        }
        return true;
    }

    public void Craft(IItemContainer invintory,List<RangeWeaponParts> parts, WeaponType weaponType)
    {
        if (CanCraft(parts))
        {
            RangeWeaponParts BacePart = null;
            foreach (var part in parts)
            {
                if (part is Baril)
                    Weapon.baril = part as Baril;
                if (part is Stock)
                    Weapon.stock = part as Stock;
                if (part is Upper)
                    Weapon.upper = part as Upper; BacePart = part;
                if (part is Lower)
                    Weapon.lower = part as Lower;
            }

            Weapon.ammoType = BacePart.ammoType;
            Weapon.weaponType = weaponType;

            invintory.AddItem(Weapon);
        }
    }
}
