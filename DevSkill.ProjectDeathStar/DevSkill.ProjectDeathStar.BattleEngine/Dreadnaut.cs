using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Dreadnaut : Ship 
    {
        private Dreadnaut(string name, string pictureUrl, uint sheild, uint armor, uint hull,
             uint range, uint weaponSlots, uint engineeringSlots, uint DefenceSlots)
        {
            Name = name;
            WeaponSlots = new IWeapon[weaponSlots];
        }

        public void InstallWeapon(IWeapon weapon, int slot)
        {
            if (weapon.Type == WeaponType.Large)
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

        public static Dreadnaut CreateDreadnaut(string shipName)
        {
            switch (shipName)
            {
                case "Phoenix":
                    return new Dreadnaut(shipName, "", 10000, 12000, 1000, 4, 10, 5, 5);
                case "Moros":
                    return new Dreadnaut(shipName, "", 12000, 1000, 8000, 4, 9, 6, 5);
                case "Naglfar":
                    return new Dreadnaut(shipName, "", 9000, 12000, 9000, 4, 9, 5, 6);
                case "Revelation":
                    return new Dreadnaut(shipName, "", 10000, 10000, 10000, 4, 10, 4, 6);
                default:
                    throw new Exception("Invalid ship name");
            }
        }

    }
}
