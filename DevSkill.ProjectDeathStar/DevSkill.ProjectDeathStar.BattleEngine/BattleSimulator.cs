using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class BattleSimulator 
    {
        public static BattleResult CalculateBattleResult(Planet offensivePlanet,
            Planet defensivePlanet)
        {
            var luckForOffensive = GenerateLuck();
            var luckForDefensive = GenerateLuck();

            for (int i = 0; i < 6; i++)
            {
                uint armor = offensivePlanet.OffensiveFormation.Rows[i].SelectedShip.Armor;
                var x = armor = offensivePlanet.OffensiveFormation.Rows[i].ShipAmount;
            }

            var result = new BattleResult();
            result.AddRound();
            result.Status = BattleStatus.OffenseSuccessful; 

            return result;

        }

        public static int GenerateLuck()
        {
            return 5;
        }


    } 
}
