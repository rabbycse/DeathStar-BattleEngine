using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class EngineeringModule
    {
        string Name { get; set; }
        int KineticDamageEffectFactor { get; set; }
        int ThermalDamageEffectFactor { get; set; }
        int ExplosiveDamageEffectFactor { get; set; }
        int ElectromagneticDamageEffectFactor { get; set; }
        int SpeedEffectFactor { get; set; }

    }
}
