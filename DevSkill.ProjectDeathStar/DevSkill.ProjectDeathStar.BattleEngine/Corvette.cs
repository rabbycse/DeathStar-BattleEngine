using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Corvette : Ship
    {
        private Corvette(string name, string pictureUrl, uint sheild, uint armor, uint hull,
             uint range, uint weaponSlots, uint engineeringSlots, uint DefenceSlots)
        {
            Name = name;
            WeaponSlots = new IWeapon[weaponSlots];
        }

        public void InstallWeapon(IWeapon weapon, int slot)
        {
            if (weapon.Type == WeaponType.Small)
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

        public static Corvette CreateCorvette(string shipName)
        {
            switch (shipName)
            {
                case "Condor":
                    return new Corvette(shipName, "", 500, 800, 300, 1, 2, 3, 2);
                case "Raptor":
                    return new Corvette(shipName, "", 400, 700, 500, 1, 3, 2, 2);
                case "Hawk":
                    return new Corvette(shipName, "", 600, 600, 400, 1, 2, 3, 2); 
                default:
                    return null;
            }
        }


    }

}
