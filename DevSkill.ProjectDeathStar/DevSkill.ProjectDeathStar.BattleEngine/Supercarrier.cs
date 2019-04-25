using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Supercarrier : Ship
    {
        private Supercarrier(string name, string pictureUrl, uint sheild, uint armor, uint hull,
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

        public static Supercarrier CreateSupercarrier(string shipName)
        {
            switch (shipName)
            {
                case "Nightmare":
                    return new Supercarrier(shipName, "", 70000, 80000, 70000, 5, 16, 10, 12);
                case "Phantom":
                    return new Supercarrier(shipName, "", 80000, 70000, 70000, 5, 16, 12, 10);
                case "Dragon":
                    return new Supercarrier(shipName, "", 70000, 70000, 80000, 5, 15, 11, 12); 
                default:
                    throw new Exception("Invalid ship name");
            }
        }


    }

}
