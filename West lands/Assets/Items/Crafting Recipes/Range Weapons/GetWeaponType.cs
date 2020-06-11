

class GetWeaponType
{
    public bool Type(WeaponList targetWeaponType,AmmoTypes ammoType, RangeWeaponParts part)
    {
        switch (targetWeaponType)
        {
            case WeaponList.AR15:
                return part.weaponList == targetWeaponType && part.ammoType == ammoType;
                
            case WeaponList.AK47:
                return part.weaponList == targetWeaponType && part.ammoType == ammoType;

            case WeaponList.M4A1:
                return part.weaponList == targetWeaponType && part.ammoType == ammoType;
            default:
                return false;
        }
    }
}
