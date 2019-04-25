using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Battlecruiser : Ship 
    {
        private Battlecruiser(string name, string pictureUrl, uint sheild, uint armor, uint hull,
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

        public static Battlecruiser CreateBattlecruiser(string shipName) 
        {
            switch (shipName)
            {
                case "Ferox":
                    return new Battlecruiser(shipName, "", 3000, 4000, 2000, 3, 6, 4, 4);
                case "Drake":
                    return new Battlecruiser(shipName, "", 4000, 3000, 2000, 3, 5, 5, 4);
                case "Naga":
                    return new Battlecruiser(shipName, "", 2500, 4500, 2000, 3, 6, 5, 3);
                case "Nighthawk":
                    return new Battlecruiser(shipName, "", 2000, 4000, 3000, 3, 6, 3, 5);
                case "Vulture":
                    return new Battlecruiser(shipName, "", 4000, 2000, 3000, 3, 6, 4, 4);
                case "Oracle":
                    return new Battlecruiser(shipName, "", 3000, 3000, 3000, 3, 5, 4, 5); 
                default:
                    return null;
            }
        }

    }

}
