using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Planet
    {
        public string Name { get; private set; }
        public uint CivilProduction { get; private set; }
        public uint MilitaryProduction  { get; private set; } 
        public BattleFormation OffensiveFormation { get; set; }
        public BattleFormation DefensiveFormation { get; set; }

        private Planet(string name, double civilProduction,
            double militaryProduction, double offense, double defense)  
        {
            Name = name;
        }

        public static Planet CreatePlanet(string planetName)  
        {
            switch (planetName)
            {
                case "Pandora":
                    return new Planet(planetName, 0.2, 0.1, 0.01, 0.02);
                case "Desert":
                    return new Planet(planetName, 0.02, 0.05, 0.10, 0.05);
                case "Lava":
                    return new Planet(planetName, 0.1, 0.2, 0.02, 0.01);
                case "Oceanic":
                    return new Planet(planetName, 0.05, 0.1, 0.15, 0.01);
                default:
                    throw new Exception("Invalid planet name");
            }
        }


    }
}
