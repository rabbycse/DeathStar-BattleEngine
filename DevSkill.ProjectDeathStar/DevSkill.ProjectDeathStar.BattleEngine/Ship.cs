using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public abstract class Ship
    {
        public string Name { get; protected set; }
        public string PictureUrl { get; protected set; } 
        public uint Sheild { get; protected set; }
        public uint Armor { get; protected set; }
        public uint Hull { get; protected set; }
        public uint Range { get; protected set; }

        public IWeapon[] WeaponSlots { get; protected set; } 
        public EngineeringModule[] EngineeringModuleSlots { get; protected set; }
        public DefenseModule[] DefenceModuleSlots { get; protected set; }

        public void RemoveWeapon(int slot)
        {
            if (slot >= 0 && slot < WeaponSlots.Length)
            {
                WeaponSlots[slot] = null;
            }
        }

        public uint CalculateTotalDamage()
        {
            uint totalDamage = 0;
            for (int i = 0; i < WeaponSlots.Length; i++)
            {
                if (WeaponSlots[i] != null)
                {
                    totalDamage += (WeaponSlots[i].KineticDamage + WeaponSlots[i].ThermalDamage
                        + WeaponSlots[i].ElectromagneticDamage + WeaponSlots[i].ExplosiveDamage);
                }
            }
            return totalDamage;

        }

    }
}
