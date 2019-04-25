using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Destroyer : Ship
    {
        private Destroyer(string name, string pictureUrl, uint sheild, uint armor, uint hull,
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

        public static Destroyer CreateDestroyer(string shipName)
        {
            switch (shipName)
            {
                case "Thrasher":
                    return new Destroyer(shipName, "", 1200, 1500, 1000, 2, 4, 3, 3);
                case "Sabre":
                    return new Destroyer(shipName, "", 1500, 1000, 1200, 2, 5, 2, 3);
                case "Bifrost":
                    return new Destroyer(shipName, "", 1000, 1500, 1200, 2, 4, 3, 2);
                case "Nemesis":
                    return new Destroyer(shipName, "", 1000, 1200, 1500, 2, 5, 3, 2);
                case "Incursus":
                    return new Destroyer(shipName, "", 1300, 1200, 1200, 2, 4, 4, 2); 
                default:
                    return null;
            }
        }

    }
}
