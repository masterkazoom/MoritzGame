using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Weapon : Item
    {
        public bool Ranged;
        public int AttackModifier;
        public Enums.DamageType DamageType;
        public Consumable ActivePoison;
        private NameGenerator namegenerator = new NameGenerator();

        /// <summary>
        /// Objekt Weapon
        /// </summary>        
        public Weapon()
        {
            Name = "Weapon";
            //Quality = 0;
            AttributeValueNeeded = 0;
            Ranged = false;
            AttackModifier = 0;
            Type = Enums.ItemType.Weapon;
            Image = Properties.Resources.itemweapon;
        }        

        public Weapon(int level, Enums.ClassName classname, Random rnd)
        {

            Ranged = false;
            LevelNeeded = level;
            Type = Enums.ItemType.Weapon;
            Subtype = SetWeaponSubtype(classname, rnd);
            Quality = SetQuality(rnd);            
            if(Quality == Enums.Quality.Legendary)
            {
                //generate super special legendary weapons
            }
            else
            {
                Image = SetImage();
                Name = SetName(rnd);
                AttributeNeeded = SetAttributeNeeded();
                DamageType = SetDamageType();
                AttackModifier = (int)SetAttackModifier(rnd);
                AttributeValueNeeded = SetAttributeValueNeeded(AttackModifier);                
            }      
            Description = Name + "\n" + "Damage: " + AttackModifier + " Attribute needed: " + AttributeNeeded + " " + AttributeValueNeeded + "\n" + "Level needed: " + LevelNeeded + " Item Quality: " + Quality + " Sell Value: " + Value + " Inventoryslot: "+Inventoryslot;
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
                    return namegenerator.magicweaponprefixnames[rnd.Next(1, 10)] + " " + Subtype;
                else
                    return Subtype + " " + namegenerator.magicweaponsuffixnames[rnd.Next(1, 10)];        
            }
            else if (Quality == Enums.Quality.Epic)
            {
                return namegenerator.magicweaponprefixnames[rnd.Next(1, 10)] + " " + Subtype + " " + namegenerator.magicweaponsuffixnames[rnd.Next(1, 10)];
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

        private Enums.ItemSubType SetWeaponSubtype(Enums.ClassName classname, Random rnd)
        {
            int chance = rnd.Next(1, 8);
            switch (chance)
            {
                case 1:
                    return Enums.ItemSubType.Sword;                    
                case 2:
                    return Enums.ItemSubType.Axe;                    
                case 3:
                    return Enums.ItemSubType.Staff;                    
                case 4:
                    return Enums.ItemSubType.Dagger;                    
                case 5:
                    return Enums.ItemSubType.Club;                    
                case 6:
                    return Enums.ItemSubType.Pike;                    
                case 7:
                    return Enums.ItemSubType.Rapier;                    
                case 8:
                    return Enums.ItemSubType.Spear;                    
                default:
                    return Enums.ItemSubType.Sword;                    
            }
        }

        private Enums.DamageType SetDamageType()
        {
            switch (Subtype)
            {
                case Enums.ItemSubType.Sword:
                    return Enums.DamageType.Slashing;
                case Enums.ItemSubType.Axe:
                    return Enums.DamageType.Slashing;
                case Enums.ItemSubType.Staff:
                    return Enums.DamageType.Bludgeoning;
                case Enums.ItemSubType.Dagger:
                    return Enums.DamageType.Piercing;
                case Enums.ItemSubType.Club:
                    return Enums.DamageType.Bludgeoning;
                case Enums.ItemSubType.Pike:
                    return Enums.DamageType.Piercing;
                case Enums.ItemSubType.Rapier:
                    return Enums.DamageType.Piercing;
                case Enums.ItemSubType.Spear:
                    return Enums.DamageType.Piercing;
                default:
                    return Enums.DamageType.Slashing;
            }
        }

        private double SetAttackModifier(Random rnd)
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
            return ((5 + (((double)LevelNeeded * 0.8))) * modifier)*random;
        }       
    }
}
