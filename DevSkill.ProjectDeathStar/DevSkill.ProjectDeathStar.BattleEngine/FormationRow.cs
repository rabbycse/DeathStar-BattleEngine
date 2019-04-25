using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class FormationRow
    {
        public Ship SelectedShip { get; private set; }
        public uint ShipAmount { get; protected set; }  

        public FormationRow(Ship selectedShip, uint shipAmount)
        {
            SelectedShip = selectedShip;
        }
    }
}
