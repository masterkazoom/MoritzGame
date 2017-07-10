using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Armor : Item
    {
        public int DefenseModifier;
        private NameGenerator namegenerator = new NameGenerator();
        /// <summary>
        /// Objekt Armor
        /// </summary>        
        public Armor()
        {
            Name = "Armor";            
            AttributeValueNeeded = 0;
            DefenseModifier = 0;
            Type = Enums.ItemType.Armor;
        }

        public Armor(int level, Enums.ClassName classname, Random rnd)
        {
            //standard item generation method, item level depending on character/monster level, subtype random, quality random
            LevelNeeded = level;
            Type = Enums.ItemType.Armor;
            Subtype = SetArmorSubtype(classname, rnd);
            Quality = SetQuality(rnd);
            if (Quality == Enums.Quality.Legendary)
            {
                //generate super special legendary weapons
            }
            else
            {
                //image depending on quality, name depending on subtype and quality, attribute depending on subtype
                Image = SetImage();
                Name = SetName(rnd);
                DefenseModifier = (int)SetDefenseModifier(rnd);
                AttributeNeeded = SetAttributeNeeded();              
                AttributeValueNeeded = SetAttributeValueNeeded(DefenseModifier);
            }
            //set description fitting for form labels
            Description = Name + "\n" + "Defense: " + DefenseModifier + " Attribute needed: " + AttributeNeeded + " " + AttributeValueNeeded + "\n" + "Level needed: " + LevelNeeded + " Item Quality: " + Quality + " Sell Value: " + Value + " Inventoryslot: " + Inventoryslot;
        }

        public string SetName(Random rnd)
        {
            if (Quality == Enums.Quality.Normal)
            {
                return Subtype.ToString();
            }
            else if (Quality == Enums.Quality.Magic)
            {
                if (rnd.Next(1, 2) == 1)
                    return namegenerator.magicarmorprefixnames[rnd.Next(1, 10)] + " " + Subtype;
                else
                    return Subtype + " " + namegenerator.magicarmorsuffixnames[rnd.Next(1, 10)];
            }
            else if (Quality == Enums.Quality.Epic)
            {
                return namegenerator.magicarmorprefixnames[rnd.Next(1, 10)] + " " + Subtype + " " + namegenerator.magicarmorsuffixnames[rnd.Next(1, 10)];
            }
            else if (Quality == Enums.Quality.Poor)
            {
                return Quality + " " + Subtype;
            }
            else
            {
                //Legendary Item
                return Quality + " " + Subtype;
            }
        }
        private Enums.ItemSubType SetArmorSubtype(Enums.ClassName classname, Random rnd)
        {
            int chance = rnd.Next(1, 5);
            switch (chance)
            {
                case 1:
                    return Enums.ItemSubType.Breastplate;
                case 2:
                    return Enums.ItemSubType.Cloak;
                case 3:
                    return Enums.ItemSubType.Boots;
                case 4:
                    return Enums.ItemSubType.Gloves;
                case 5:
                    return Enums.ItemSubType.Helmet;               
                default:
                    return Enums.ItemSubType.Breastplate;
            }
        }

        private double SetDefenseModifier(Random rnd)
        {
            double modifier = 1;
            if (Quality == Enums.Quality.Poor)
            {
                modifier = 0.75;
            }
            else if (Quality == Enums.Quality.Normal)
            {
                modifier = 1;
            }
            else if (Quality == Enums.Quality.Magic)
            {
                modifier = 1.4;
            }
            else if (Quality == Enums.Quality.Epic)
            {
                modifier = 1.8;
            }
            double random = ((rnd.Next(1, 4) * 0.25) + 0.5);
            return ((4 + (((double)LevelNeeded * 0.9))) * modifier) * random;
        }
    }
}
