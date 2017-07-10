using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Consumable : Item
    {
        public string EffectText;
        public string AffectedAttribute;
        public double EffectModifier;

        public Consumable()
        {
            Name = "Potion";
            EffectText = "Effect";
            AffectedAttribute = "";
            EffectModifier = 0;
            Type = Enums.ItemType.Consumable;            
            Description = Name + "\n" + Type + " "+EffectText+": " + EffectModifier + " Level Needed: " + LevelNeeded + " Value: " + Value;
        }

        public Consumable(Enums.ItemSubType subtype, int level, Random rnd)
        {
            Name = "Potion";
            EffectText = "Effect";
            AffectedAttribute = "";
            EffectModifier = 0;
            Type = Enums.ItemType.Consumable;
            Subtype = subtype;
            Description = Name + "\n" + Type + " " + EffectText + ": " + EffectModifier + " Level Needed: " + LevelNeeded + " Value: " + Value;
        }
    }
}
