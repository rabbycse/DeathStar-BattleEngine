using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class BattleFormation
    {
        public string Name { get; set; }
        public FormationRow[] Rows { get; private set; }
        public bool IsActive { get; private set; }
        public General GeneralInCharge { get; private set; }

        public BattleFormation(string name)
        {
            Name = name;
            Rows = new FormationRow[6];
        }

        public void SetFormationRow(Ship selectedShip, uint amountOfShips,uint rowPosition)
        {
            if (rowPosition < 6)
            {
                Rows[rowPosition] = new FormationRow(selectedShip, amountOfShips);
            }
            else
                throw new Exception("Invalid Row Position");
        }

        public void ActivateFormation(General assignedGeneral)
        {
            GeneralInCharge = assignedGeneral;
            IsActive = true;
        }

        
    }
}
