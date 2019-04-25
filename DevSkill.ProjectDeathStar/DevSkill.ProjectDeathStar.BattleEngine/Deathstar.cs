using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Deathstar : Ship
    {
        private Deathstar(string name, string pictureUrl, uint sheild, uint armor, uint hull,
             uint range, uint weaponSlots, uint engineeringSlots, uint DefenceSlots)
        {
            Name = name;
            WeaponSlots = new IWeapon[weaponSlots];
        }

        public void InstallWeapon(IWeapon weapon, int slot) 
        {
            if (weapon.Type == WeaponType.Doomsday)
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

        public static Deathstar CreateDeathstar(string shipName) 
        {
            switch (shipName)
            {
                case "Astero":
                    return new Deathstar(shipName, "", 1000000, 1000000, 1000000, 6, 3, 3, 3);
                case "Dramiel":
                    return new Deathstar(shipName, "", 900000, 1100000, 1000000, 6, 3, 2, 4);
                case "Terminator":
                    return new Deathstar(shipName, "", 1100000, 1000000, 1000000, 6, 3, 4, 2);
                default:
                    throw new Exception("Invalid ship name");
            }
        }


    }

}
