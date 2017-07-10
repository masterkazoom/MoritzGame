using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Affix
    {
        string Name;
        string EffectDescription;
        string AffectedAttribute;
        string AffectedItemType;
        string AffixType;
        double EffectStrengthMin;
        double EffectStrengthMax;

        public Affix(Random rnd)
        {
            MoritzGameDataSet dataset1 = new MoritzGameDataSet();
            MoritzGameDataSetTableAdapters.AffixTableAdapter adapter = new MoritzGameDataSetTableAdapters.AffixTableAdapter();

            adapter.Fill(dataset1.Affix);

            DataRow row = dataset1.Affix.Rows[rnd.Next(1, dataset1.Affix.Rows.Count)];

            Name = row[1].ToString();
            EffectDescription = row[2].ToString();
            AffectedAttribute = row[3].ToString();
            AffectedItemType = row[4].ToString();
            AffixType = row[5].ToString();
            EffectStrengthMin = (double)row[6];
            EffectStrengthMax = (double)row[7];
        }

        public Affix(Random rnd, Enums.ItemType itemtype)
        {
            MoritzGameDataSet dataset1 = new MoritzGameDataSet();
            MoritzGameDataSetTableAdapters.AffixTableAdapter adapter = new MoritzGameDataSetTableAdapters.AffixTableAdapter();

            if (itemtype == Enums.ItemType.Weapon)
            {
                adapter.FillWeapon(dataset1.Affix);
            }
            else if (itemtype == Enums.ItemType.Armor)
            {
                adapter.FillArmor(dataset1.Affix);
            }
            else
            {
                adapter.FillConsumable(dataset1.Affix);
            }

            DataRow row = dataset1.Affix.Rows[rnd.Next(1, dataset1.Affix.Rows.Count)];
            Name = row[1].ToString();
            EffectDescription = row[2].ToString();
            AffectedAttribute = row[3].ToString();
            AffectedItemType = row[4].ToString();
            EffectStrengthMin = (double)row[6];
            EffectStrengthMax = (double)row[7];
            AffixType = row[5].ToString();
        }



        public Affix(Random rnd, Enums.ItemType itemtype, string affixtype)

        {
            MoritzGameDataSet dataset1 = new MoritzGameDataSet();
            MoritzGameDataSetTableAdapters.AffixTableAdapter adapter = new MoritzGameDataSetTableAdapters.AffixTableAdapter();

            if (itemtype == Enums.ItemType.Weapon && affixtype == "prefix")
            {
                adapter.FillWeaponPrefix(dataset1.Affix);
            }
            else if (itemtype == Enums.ItemType.Weapon && affixtype == "suffix")
            {
                adapter.FillWeaponSuffix(dataset1.Affix);
            }
            else if (itemtype == Enums.ItemType.Armor && affixtype == "prefix")
            {
                adapter.FillArmorPrefix(dataset1.Affix);
            }
            else if (itemtype == Enums.ItemType.Armor && affixtype == "suffix")
            {
                adapter.FillArmorSuffix(dataset1.Affix);
            }
            else if (itemtype == Enums.ItemType.Consumable && affixtype == "prefix")
            {
                adapter.FillConsumablePrefix(dataset1.Affix);
            }
            else if (itemtype == Enums.ItemType.Consumable && affixtype == "suffix")
            {
                adapter.FillConsumableSuffix(dataset1.Affix);
            }
            else
            {
                adapter.Fill(dataset1.Affix);
            }



            DataRow row = dataset1.Affix.Rows[rnd.Next(1, dataset1.Affix.Rows.Count)];
            Name = row[1].ToString();
            EffectDescription = row[2].ToString();
            AffectedAttribute = row[3].ToString();
            AffectedItemType = row[4].ToString();
            AffixType = row[5].ToString();
            EffectStrengthMin = (double)row[6];
            EffectStrengthMax = (double)row[7];          
        }

    }
}
