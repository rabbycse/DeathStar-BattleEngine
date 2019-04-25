using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Cruiser : Ship
    {
        private Cruiser(string name, string pictureUrl, uint sheild, uint armor, uint hull,
             uint range, uint weaponSlots, uint engineeringSlots, uint DefenceSlots)
        {
            Name = name;
            WeaponSlots = new IWeapon[weaponSlots];
        }

        public void InstallWeapon(IWeapon weapon, int slot)
        {
            if (weapon.Type == WeaponType.Medium)
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

        public static Cruiser CreateCruiser(string shipName) 
        {
            switch (shipName)
            {
                case "Thorax":
                    return new Cruiser(shipName, "", 2000, 3000, 1500, 3, 5, 4, 3);
                case "Vexor":
                    return new Cruiser(shipName, "", 3000, 2000, 1500, 3, 5, 3, 4);
                case "Deimos":
                    return new Cruiser(shipName, "", 2000, 2500, 2000, 3, 6, 3, 3);
                case "Caracal":
                    return new Cruiser(shipName, "", 1500, 3000, 2000, 3, 5, 5, 2);
                case "Blackbird":
                    return new Cruiser(shipName, "", 2500, 2000, 2000, 3, 5, 2, 5);
                default:
                    return null;
            }
        }

    }

}
