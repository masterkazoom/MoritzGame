using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Hero: NPC
    {
        

        public Hero()
        {
            Name = "Bob";
            Strength = 8;
            Dexterity = 8;
            Intelligence = 8;
            Endurance = 12;         
            MagicResistance = 0;
            BluntResistance = 0;
            SlashResistance = 0;
            PierceResistance = 0;          
            Type = Enums.NPCType.Hero;
            ClassName = Enums.ClassName.Hero;            
            PC = true;
            MainAttribute = Enums.Attribute.Strength;
            SecondaryAttribute = Enums.Attribute.Dexterity;
            Resource = GetResourceStat();
            ResourceMax = Resource;
            Health = GetHealthStat();
            CurrentHealth = Health;
            Evasion = GetEvasionStat();
            Defense = GetDefenseStat();
            Evasionstring = Evasion.ToString("P2");
        }
        
    }
}
