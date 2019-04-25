using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Shuttle : Ship
    {
        private Shuttle(string name, string pictureUrl, uint sheild, uint armor, uint hull,
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

        public static Shuttle CreateShuttle(string shipName)
        {
            switch (shipName)
            {
                case "Comet":
                    return new Shuttle(shipName, "", 300, 500, 200, 1, 1, 2, 1);
                case "Griffin":
                    return new Shuttle(shipName, "", 400, 400, 200, 1, 1, 1, 2);
                default:
                    throw new Exception("Invalid ship name");
            }
        }

    }

}
