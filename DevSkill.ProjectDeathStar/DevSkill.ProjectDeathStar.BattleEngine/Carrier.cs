using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Carrier : Ship
    {
        private Carrier(string name, string pictureUrl, uint sheild, uint armor, uint hull,
             uint range, uint weaponSlots, uint engineeringSlots, uint DefenceSlots)
        {
            Name = name;
            WeaponSlots = new IWeapon[weaponSlots];
        }

        public void InstallWeapon(IWeapon weapon, int slot)
        {
            if (weapon.Type == WeaponType.XLarge)
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

        public static Carrier CreateCarrier(string shipName)
        {
            switch (shipName)
            {
                case "Hel":
                    return new Carrier(shipName, "", 40000, 50000, 30000, 5, 15, 10, 10);
                case "Loggerhead":
                    return new Carrier(shipName, "", 30000, 40000, 50000, 5, 15, 8, 12);
                case "Revenant":
                    return new Carrier(shipName, "", 40000, 40000, 40000, 5, 15, 12, 8);
                default:
                    throw new Exception("Invalid ship name");
            }
        }


    }

}
