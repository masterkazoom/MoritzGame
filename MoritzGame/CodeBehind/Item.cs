using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MoritzGame.CodeBehind
{
    class Item
    {
        public string Name;
        public Enums.Quality Quality = Enums.Quality.Normal;
        public Enums.ItemType Type;
        public Enums.ItemSubType Subtype;
        public Enums.Attribute AttributeNeeded;
        public int LevelNeeded;
        public int Value;
        public int AttributeValueNeeded;
        public int Inventoryslot;
        public Affix[] Affix;
        public string ClassItem = "";
        public int StrengthBonus = 0;
        public int DexterityBonus = 0;
        public int IntelligenceBonus = 0;
        public int EnduranceBonus = 0;
        public double DefenseBonus = 0;
        public double HealthBonus = 0;
        public double DamageBonus = 0;
        public double ResourceBonus = 0;
        public double EvasionBonus = 0;
        public double MagicResistanceBonus = 0;
        public double BluntResistanceBonus = 0;
        public double SlashResistanceBonus = 0;
        public double PierceResistanceBonus = 0;
        public string Description;
        public Bitmap Image = Properties.Resources.itemempty;

        public Item()
        {
            Name = "Item";            
            Type = Enums.ItemType.Item;            
            Inventoryslot = 10;
            LevelNeeded = 1;
            Value = 10;
        }
        /// <summary>
        /// Objekt Item, Type festlegen
        /// </summary>
        /// <param name="type"></param>
        public Item(Enums.ItemType type)
        {
            Name = "Item";          
            Inventoryslot = 10;
            Type = type;
        }

        /// <summary>
        /// prüfe ob das Item anlegbar ist
        /// </summary>
        /// <param name="hero1">Held</param>
        /// <returns>true = Item kann angelegt werden</returns>
        public bool IsEquippable(NPC hero1)
        {
            switch (this.AttributeNeeded)
            {
                case Enums.Attribute.Strength:
                    if (hero1.Strength >= this.AttributeValueNeeded)
                        return true;
                    return false;
                case Enums.Attribute.Dexterity:
                    if (hero1.Dexterity >= this.AttributeValueNeeded)
                        return true;
                    return false;
                case Enums.Attribute.Intelligence:
                    if (hero1.Intelligence >= this.AttributeValueNeeded)
                        return true;
                    return false;
                case Enums.Attribute.Endurance:
                    if (hero1.Endurance >= this.AttributeValueNeeded)
                        return true;
                    return false;
                default:
                    return false;
            }
        }        

        public Enums.Quality SetQuality(Random rnd)
        {
            //give item poor, normal, magic, epic or legendary quality
            double chance = rnd.NextDouble();
            if (chance <= 0.1)
            {
                //poor quality
                return Enums.Quality.Poor;
            }
            else if (chance >= 0.95)
            {
                //legendary quality
                return Enums.Quality.Legendary;
            }
            else if (chance >= 0.8)
            {
                //epic quality
                return Enums.Quality.Epic;
            }
            else if (chance >= 0.5)
            {
                //magic quality
                if (rnd.NextDouble() > 0.75)
                {
                    Affix = new Affix[2];
                    Affix[0] = new Affix(rnd, Type, "prefix");
                    Affix[1] = new Affix(rnd, Type, "suffix");
                }
                else
                {
                    Affix = new Affix[1];
                    Affix[0] = new Affix(rnd, Type);
                }
                return Enums.Quality.Magic;
            }
            else
            {
                //normal quality
                return Enums.Quality.Normal;
            }
        }

        public Bitmap SetImage()
        {
            //set item image depending on type and quality
            if(Type == Enums.ItemType.Weapon)
                switch (Quality)
                {
                    case Enums.Quality.Magic:
                        return Properties.Resources.itemweaponmagic;
                    case Enums.Quality.Epic:
                        return Properties.Resources.itemweaponepic;
                    default:
                        return Properties.Resources.itemweapon;
                }
            if(Type == Enums.ItemType.Armor)
                switch (Quality)
                {
                    case Enums.Quality.Magic:
                        return Properties.Resources.itemarmormagic;
                    case Enums.Quality.Epic:
                        return Properties.Resources.itemarmorepic;
                    default:
                        return Properties.Resources.itemarmor;
                }
            if (Type == Enums.ItemType.Consumable)
                switch (Quality)
                {
                    case Enums.Quality.Magic:
                        return Properties.Resources.itemconsumablemagic;
                    case Enums.Quality.Epic:
                        return Properties.Resources.itemconsumableepic;
                    default:
                        return Properties.Resources.itemconsumable;
                }
            return Properties.Resources.itemempty;
        }

        

        public Enums.Attribute SetAttributeNeeded()
        {
            //give item attribute depending on subtype
            switch (Subtype)
            {
                case Enums.ItemSubType.Sword:
                    return Enums.Attribute.Strength;
                case Enums.ItemSubType.Axe:
                    return Enums.Attribute.Strength;
                case Enums.ItemSubType.Staff:
                    return Enums.Attribute.Intelligence;
                case Enums.ItemSubType.Dagger:
                    return Enums.Attribute.Dexterity;
                case Enums.ItemSubType.Club:
                    return Enums.Attribute.Strength;
                case Enums.ItemSubType.Pike:
                    return Enums.Attribute.Strength;
                case Enums.ItemSubType.Rapier:
                    return Enums.Attribute.Dexterity;
                case Enums.ItemSubType.Spear:
                    return Enums.Attribute.Strength;
                default:
                    return Enums.Attribute.Strength;                
            }
        }
        public int SetAttributeValueNeeded(int value)
        {
            //set attribute value needed depending on modifier
            return (int)Math.Ceiling(value * 0.3);
        }

    }
}
