using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Battleship : Ship
    {

        private Battleship(string name, string pictureUrl, uint sheild, uint armor, uint hull,
             uint range, uint weaponSlots, uint engineeringSlots, uint defenceSlots)
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


        public static Battleship CreateBattleship(string shipName)
        {
            switch (shipName)
            {
                case "Reven":
                    return new Battleship(shipName, "", 7000, 8000, 5000, 4, 8, 4, 5);
                case "Dominix":
                    return new Battleship(shipName, "", 8000, 7000, 5000, 4, 7, 5, 5);
                case "Scorpion":
                    return new Battleship(shipName, "", 7000, 7000, 6000, 4, 8, 3, 6);
                case "Widow":
                    return new Battleship(shipName, "", 9000, 7000, 4000, 4, 8, 5, 4);
                case "Rokh":
                    return new Battleship(shipName, "", 7000, 8000, 5000, 4, 7, 4, 6);
                default:
                    throw new Exception("Invalid ship name");
            }
        }
    }
}
