using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    
    class NPC
    {
        public string Name;
        public Enums.ClassName ClassName;
        public string Evasionstring;
        public Enums.NPCType Type;
        public double Strength;
        public double Dexterity;
        public double Intelligence;
        public double Endurance;
        public double Resource;
        public double ResourceMax;
        public Enums.Resource ResourceName = Enums.Resource.Mana;
        public double Health;
        public double CurrentHealth;
        public double Defense;
        public double Damage;
        public double Evasion;
        public double MagicResistance;
        public double BluntResistance;
        public double SlashResistance;
        public double PierceResistance;
        public Enums.Attribute MainAttribute;
        public Enums.Attribute SecondaryAttribute;
        public double NeededExperience = 150;
        public int Level = 1;
        public double Experience = 0;
        public int Coin = 0;
        public bool Armed = false;
        public bool Armored = false;
        public bool PC = false;
        public Enums.UnarmedAttack UnarmedAttack = Enums.UnarmedAttack.fists;
        public int HeroRank = 0;
        public Inventory Inventar = new Inventory();
        public Weapon EquippedWeapon;
        public Armor EquippedArmor;

        public double GetAttributeStat(Enums.Attribute stat)
        {
            if (stat == Enums.Attribute.Strength)
            {
                return Strength;
            }
            else if (stat == Enums.Attribute.Dexterity)
            {
                return Dexterity;
            }
            else
            {
                return Intelligence;
            }
        }

        public double GetResourceStat()
        {
            double resource = Math.Round(10 + (Level / 2) + (Intelligence / 3));
            return resource;
        }
        public double GetHealthStat()
        {
            double stat = 10 * Endurance;
            return stat;
        }

        public double GetEvasionStat()
        {
            double evasion = (Dexterity / (100 + (Level * 2)));
            return evasion;
        }

        public double GetDefenseStat()
        {
            if (Armored)
            {
                return 5 + ((BluntResistance + 1) / 10) + ((SlashResistance + 1) / 10) + ((PierceResistance + 1) / 10) + ((MagicResistance + 1) / 10) + EquippedArmor.DefenseModifier;
            }
            else
            {
                return 5 + ((BluntResistance + 1) / 10) + ((SlashResistance + 1) / 10) + ((PierceResistance + 1) / 10) + ((MagicResistance + 1) / 10);
            }
        }

        public double GetDamageStat()
        {
            if (Armed)
            {
                return ((GetAttributeStat(MainAttribute) / 2) + (GetAttributeStat(SecondaryAttribute) / 4)) + EquippedWeapon.AttackModifier;
            }
            else
            {
                return ((GetAttributeStat(MainAttribute) / 2) + (GetAttributeStat(SecondaryAttribute) / 4));
            }
        }

        public bool IsHero()
        {
            if (PC == true)
            {
                return true;
            }
            return false;
        }
        public void EquipItemFromInventory(Item item)
        {
            if (item.Inventoryslot < 11)
            {
                if (IsHero())
                {
                    if (item.Type == Enums.ItemType.Armor)
                    {
                        if (Armored)
                        {
                            if (item.IsEquippable(this) == true)
                            {
                                Item oldarmor = EquippedArmor;
                                EquippedArmor = Inventar.TakeItemFromInventory(item.Inventoryslot) as Armor;
                                EquippedArmor.Inventoryslot = 14;
                                Inventar.AddToInventory(oldarmor);
                            }
                        }
                        else
                        {
                            if (item.IsEquippable(this) == true)
                            {
                                EquippedArmor = Inventar.TakeItemFromInventory(item.Inventoryslot) as Armor;
                                EquippedArmor.Inventoryslot = 14;
                                Armored = true;
                            }
                        }
                    }
                    else if (item.Type == Enums.ItemType.Weapon)
                    {
                        if (Armed)
                        {
                            if (item.IsEquippable(this) == true)
                            {
                                Item oldweapon = EquippedWeapon;
                                EquippedWeapon = Inventar.TakeItemFromInventory(item.Inventoryslot) as Weapon;
                                EquippedWeapon.Inventoryslot = 13;
                                Inventar.AddToInventory(oldweapon);
                            }
                        }
                        else
                        {
                            if (item.IsEquippable(this) == true)
                            {
                                EquippedWeapon = Inventar.TakeItemFromInventory(item.Inventoryslot) as Weapon;
                                EquippedWeapon.Inventoryslot = 13;
                                Armed = true;
                            }
                        }
                    }
                }
            }
        }
    }

}
