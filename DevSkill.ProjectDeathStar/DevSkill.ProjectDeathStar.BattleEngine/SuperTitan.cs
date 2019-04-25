using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class SuperTitan : Ship
    {
        private SuperTitan(string name, string pictureUrl, uint sheild, uint armor, uint hull,
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

        public static SuperTitan CreateSuperTitan(string shipName)
        {
            switch (shipName)
            {
                case "Leviathan":
                    return new SuperTitan(shipName, "", 200000, 400000, 300000, 6, 20, 10, 10);
                case "Komodo":
                    return new SuperTitan(shipName, "", 300000, 400000, 200000, 6, 20, 8, 12);
                case "Cynabal":
                    return new SuperTitan(shipName, "", 300000, 300000, 300000, 6, 20, 12, 8);
                case "Machariel":
                    return new SuperTitan(shipName, "", 250000, 350000, 300000, 6, 20, 10, 10);
                default:
                    throw new Exception("Invalid ship name");
            }
        }


    }

}
