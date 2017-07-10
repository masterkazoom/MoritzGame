using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Enums
    {
        public enum NPCType
        {
            Monster,
            Hero            
        }

        public enum ItemType
        {
            Item,
            Weapon,
            Armor,
            Consumable
        }

        public enum ClassName
        {
            Monster,
            Hero
        }

        public enum Resource
        {
            Mana,
            Energy
        }

        public enum Attribute
        {
            Strength,
            Dexterity,
            Intelligence,
            Endurance
        }

        public enum UnarmedAttack
        {
            fists
        }

        public enum Quality
        {
            Poor,
            Normal,
            Magic,
            Epic,
            Legendary
        }

        public enum ItemSubType
        {
            Breastplate,
            Cloak,
            Boots,
            Gloves,
            Helmet,                       
            Sword, 
            Axe,            
            Staff,                
            Dagger,                  
            Club,                    
            Pike,                  
            Rapier,
            Spear                        
        }

        public enum DamageType
        {
            Slashing,
            Piercing,
            Bludgeoning
        }
    }
}
