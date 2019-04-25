using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class General
    {
        public string Foresight { get; protected set; }
        public string Brutality { get; protected set; }
        public string Willpower { get; protected set; }

        public General(string foresight, string brutality, string willpower)
        {
            Foresight = foresight;
            Brutality = brutality;
            Willpower = willpower;
        }


    }
}
