using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Juggernaut : Ship
    {
        private Juggernaut(string name, string pictureUrl, uint sheild, uint armor, uint hull,
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

        public static Juggernaut CreateJuggernaut(string shipName)
        {
            switch (shipName)
            {
                case "Aeon":
                    return new Juggernaut(shipName, "", 20000, 30000, 20000, 5, 12, 8, 5);
                case "Archon":
                    return new Juggernaut(shipName, "", 30000, 20000, 20000, 5, 11, 9, 5);
                case "Thanatos":
                    return new Juggernaut(shipName, "", 25000, 25000, 20000, 5, 11, 7, 7);
                case "Nyx":
                    return new Juggernaut(shipName, "", 25000, 20000, 25000, 5, 12, 7, 6); 
                default:
                    throw new Exception("Invalid ship name");
            }
        }

    }
}
