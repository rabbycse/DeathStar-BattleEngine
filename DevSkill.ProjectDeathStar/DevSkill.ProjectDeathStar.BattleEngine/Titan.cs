using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Titan : Ship
    {
        private Titan(string name, string pictureUrl, uint sheild, uint armor, uint hull,
             uint range, uint weaponSlots, uint engineeringSlots, uint DefenceSlots)
        {
            Name = name;
            WeaponSlots = new IWeapon[weaponSlots];
        }

        public void InstallWeapon(IWeapon weapon, int slot)
        {
            if (weapon.Type == WeaponType.XXLarge)
            {
                if (slot < this.WeaponSlots.Length)
                {
                    this.WeaponSlots[slot] = weapon;
                }
                else
                    throw new Exception("Invalid Slot");
            }
            else
                throw new Exception("Invalid Weapon");
        }

        public static Titan CreateTitan(string shipName) 
        {
            switch (shipName)
            {
                case "Molok":
                    return new Titan(shipName, "", 100000, 120000, 100000, 6, 18, 12, 18);
                case "Avatar":
                    return new Titan(shipName, "", 120000, 100000, 100000, 6, 18, 10, 10);
                case "Erebus":
                    return new Titan(shipName, "", 100000, 100000, 120000, 6, 18, 8, 12);
                default:
                    return null;
            }
        }


    }

}
