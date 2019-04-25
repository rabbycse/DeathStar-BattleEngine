using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class BattleResult
    {
        public List<BattleRound> Rounds { get; private set; }
        public BattleStatus Status { get; set; }

        public BattleResult()
        {
            Rounds = new List<BattleRound>();
        }

        public void AddRound(BattleFormation offensiveFormation,
            BattleFormation defensiveFormation)
        {
            Rounds.Add(new BattleRound((uint)Rounds.Count + 1, offensiveFormation, defensiveFormation));

        }

        public void AddRound()
        {
            throw new NotImplementedException();
        }
    }
}
