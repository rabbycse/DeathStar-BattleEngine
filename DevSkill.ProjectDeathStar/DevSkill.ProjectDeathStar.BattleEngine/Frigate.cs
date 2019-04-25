using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Frigate : Ship
    {
        private Frigate(string name, string pictureUrl, uint sheild, uint armor, uint hull,
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

        public static Frigate CreateFrigate(string shipName) 
        {
            switch (shipName)
            {
                case "Heron":
                    return new Frigate(shipName, "", 800, 1000, 600, 2, 3, 3, 3);
                case "Slicer":
                    return new Frigate(shipName, "", 700, 900, 800, 2, 4, 2, 3); 
                case "Punisher":
                    return new Frigate(shipName, "", 900, 900, 600, 2, 3, 2, 4);
                case "Vengeance":
                    return new Frigate(shipName, "", 1000, 900, 500, 2, 3, 4, 2);
                case "Rifter":
                    return new Frigate(shipName, "", 600, 900, 900, 2, 4, 3, 2); 
                default:
                    return null;
            }
        }

    }

}
