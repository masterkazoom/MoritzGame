using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Monster: NPC
    {
        public Monster()
        {
            Name = "Monster";
            Strength = 8;
            Dexterity = 8;
            Intelligence = 8;
            Endurance = 12;
            Resource = GetResourceStat();
            ResourceMax = Resource;
            Health = GetHealthStat();
            CurrentHealth = Health;
            MagicResistance = 0;
            BluntResistance = 0;
            SlashResistance = 0;
            PierceResistance = 0;
            Evasion = GetEvasionStat();
            Evasionstring = Evasion.ToString("P2");
            Type = Enums.NPCType.Monster;
            ClassName = Enums.ClassName.Monster;
            Defense = GetDefenseStat();
            PC = false;
            MainAttribute = Enums.Attribute.Strength;
            SecondaryAttribute = Enums.Attribute.Dexterity;
        }
    }
}
