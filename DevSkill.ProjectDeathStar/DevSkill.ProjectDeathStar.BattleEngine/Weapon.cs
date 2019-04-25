using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Weapon : IWeapon
    {
        public string Name { get; private set; }
        public string PictureUrl { get; private set; }
        public uint KineticDamage { get; private set; }
        public uint ThermalDamage { get; private set; }
        public uint ExplosiveDamage { get; private set; }
        public uint ElectromagneticDamage { get; private set; }
        public WeaponType Type { get; private set; }

        private Weapon(string name, string pictureUrl, uint kineticDamage,
            uint thermalDamage, uint explosiveDamage, uint electromagneticDamage, WeaponType type)
        {
            Type = type; 
        }

        public static Weapon CreateWeapon(string name, WeaponType type) 
        {
            switch (name)
            { 
          
                case "Cannon":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 0, 10, 0, 20, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 0, 20, 0, 40, type);
                    else if (type == WeaponType.Large)
                        return new Weapon(name, "", 0, 50, 0, 100, type);
                    else if (type == WeaponType.XLarge)
                        return new Weapon(name, "", 0, 100, 0, 200, type);
                    else if (type == WeaponType.XXLarge)
                        return new Weapon(name, "", 0, 500, 0, 1000, type);
                    else
                        return null;

                case "Projectile":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 10, 10, 0, 10, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 20, 20, 0, 20, type);
                    else if (type == WeaponType.Large)
                        return new Weapon(name, "", 50, 50, 0, 50, type);
                    else if (type == WeaponType.XLarge)
                        return new Weapon(name, "", 100, 100, 0, 100, type);
                    else if (type == WeaponType.XXLarge)
                        return new Weapon(name, "", 500, 500, 0, 500, type);
                    else
                        return null;

                case "Laser":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 20, 0, 10, 0, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 40, 0, 20, 0, type);
                    else if (type == WeaponType.Large)
                        return new Weapon(name, "", 100, 0, 50, 0, type);
                    else if (type == WeaponType.XLarge)
                        return new Weapon(name, "", 200, 0, 100, 0, type);
                    else if (type == WeaponType.XXLarge)
                        return new Weapon(name, "", 1000, 0, 500, 0, type);
                    else
                        return null;

                case "Missile":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 10, 20, 0, 0, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 20, 40, 0, 0, type);
                    else if (type == WeaponType.Large)
                        return new Weapon(name, "", 50, 100, 0, 0, type);
                    else if (type == WeaponType.XLarge)
                        return new Weapon(name, "", 100, 200, 0, 0, type);
                    else if (type == WeaponType.XXLarge)
                        return new Weapon(name, "", 500, 1000, 0, 0, type);
                    else
                        return null;

                case "Shockwave":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 0, 0, 30, 0, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 0, 0, 60, 0, type);
                    else if (type == WeaponType.Large)
                        return new Weapon(name, "", 0, 0, 150, 0, type);
                    else if (type == WeaponType.XLarge)
                        return new Weapon(name, "", 0, 0, 300, 0, type);
                    else if (type == WeaponType.XXLarge)
                        return new Weapon(name, "", 0, 0, 1500, 0, type);
                    else
                        return null;

                case "DoomsdayBeam":
                     if (type == WeaponType.Doomsday)
                        return new Weapon(name, "", 0, 0, 30000, 0, type);
                    else
                        return null;
                case "DoomsdayMissile":
                    if (type == WeaponType.Doomsday)
                        return new Weapon(name, "", 10000, 20000, 0, 0, type);
                    else
                        return null;
                case "DoomsdayCannon":
                    if (type == WeaponType.Doomsday)
                        return new Weapon(name, "", 10000, 10000, 0, 10000, type);
                    else
                        return null;
                default:
                    return null;
            }
        }


    }
}
