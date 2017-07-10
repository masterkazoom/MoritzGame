using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoritzGame.CodeBehind;
using MoritzGame.Forms;

namespace MoritzGame
{
    public partial class HeroForm1 : Form
    {        
        ToolTip wpntooltip = new ToolTip();
        ToolTip armtooltip = new ToolTip();
        ToolTip inventoryttip1 = new ToolTip();
        ToolTip inventoryttip2 = new ToolTip();
        ToolTip inventoryttip3 = new ToolTip();
        ToolTip inventoryttip4 = new ToolTip();
        ToolTip inventoryttip5 = new ToolTip();
        ToolTip inventoryttip6 = new ToolTip();
        ToolTip inventoryttip7 = new ToolTip();
        ToolTip inventoryttip8 = new ToolTip();
        ToolTip inventoryttip9 = new ToolTip();
        ToolTip inventoryttip10 = new ToolTip();
        Form mainform;
        Hero mainhero;

        public HeroForm1()
        {
            InitializeComponent();         
        }

        internal Hero InitializeHero(Hero hero1, Form form)
        {
            //if hero already exists, give same hero back, else give dialog to create new hero
            mainform = form;
            if (hero1 == null)
            {
                //ask if hero should be created
                DialogResult dialogResult = MessageBox.Show("No Hero found! Do you want to create a hero?", "Missing Hero", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    hero1 = new Hero();
                    //HeroAddNameForm1 heronameform = new HeroAddNameForm1();
                    //if (heronameform.ShowDialog(this) == DialogResult.OK)
                    //{
                    //    hero1.Name = heronameform.textBox1.Text;
                    //}
                    //heronameform.Dispose();                
                    mainhero = hero1;
                    UpdateHeroPanel(mainhero);
                    return mainhero;
                }
                //no hero - hero panel is empty
                else if (dialogResult == DialogResult.No)
                {
                    HeroPanel1.Visible = false;
                    HeroSelectLabel1.Text = "You do not have a Hero.";
                    return null;
                }                
            }
            mainhero = hero1;
            //update the panel with the hero statistics
            UpdateHeroPanel(mainhero);            
            return mainhero;
        }

        private void HeroButton1_Click(object sender, EventArgs e)
        {
            //hide hero form and show main form again
            this.Hide();
            mainform.Show();
        }

        private void UpdateHeroPanel(Hero hero1)
        {
            //update every label on the hero form with hero stats
            HeroPanel1.Visible = true;
            hero1.Defense = hero1.GetDefenseStat();
            hero1.Damage = hero1.GetDamageStat();

            HeroNameLbl.Text = hero1.Name+", "+hero1.ClassName;           

            if (hero1.MainAttribute == Enums.Attribute.Strength)
            {
                HeroMainStatLbl.Text = hero1.MainAttribute + ": " + hero1.Strength.ToString();
                HeroSecStatLbl.Text = hero1.SecondaryAttribute + ": " + hero1.Dexterity.ToString();
                HeroTertStatLbl.Text = "Intelligence: " + hero1.Intelligence.ToString();
            }
            if (hero1.MainAttribute == Enums.Attribute.Dexterity)
            {
                HeroMainStatLbl.Text = hero1.MainAttribute + ": " + hero1.Dexterity.ToString();
                HeroSecStatLbl.Text = hero1.SecondaryAttribute + ": " + hero1.Intelligence.ToString();
                HeroTertStatLbl.Text = "Strength: " + hero1.Strength.ToString();
            }
            if (hero1.MainAttribute == Enums.Attribute.Intelligence)
            {
                HeroMainStatLbl.Text = hero1.MainAttribute + ": " + hero1.Intelligence.ToString();
                HeroSecStatLbl.Text = hero1.SecondaryAttribute + ": " + hero1.Strength.ToString();
                HeroTertStatLbl.Text = "Dexterity: " + hero1.Dexterity.ToString();
            }
            HeroEndLbl.Text = "Endurance: " + hero1.Endurance.ToString();
            HeroHealthLbl.Text = "Health: " + hero1.CurrentHealth.ToString()+"/"+ hero1.Health.ToString();
            HeroResourceLbl.Text = hero1.ResourceName + ": " + hero1.Resource.ToString() + "/" + hero1.ResourceMax.ToString();
            HeroDefenseLbl.Text = "Defense: " + hero1.Defense.ToString();
            HeroDamageLbl.Text = "Damage: " + hero1.Damage.ToString();
            HeroEvaLbl.Text = "Evasion: "+hero1.Evasionstring;
            HeroLevelLbl.Text = "Level: "+hero1.Level.ToString();
            HeroXPLbl.Text = "XP: " + hero1.Experience.ToString() + "/" + hero1.NeededExperience.ToString();
            HeroCoinLbl.Text = "Coin: " + hero1.Coin.ToString();

            //update item images
            if (hero1.Armed)
            {
                HeroWpnPic1.Image = hero1.EquippedWeapon.Image;
                wpntooltip.SetToolTip(this.HeroWpnPic1, hero1.EquippedWeapon.Description);
            }
            else
            {
                HeroWpnPic1.Image = Properties.Resources.itembgweapon;
                wpntooltip.SetToolTip(this.HeroWpnPic1, "You do not have a weapon equipped");
            }
            if(hero1.Armored)
            {
                HeroArmPic1.Image = hero1.EquippedArmor.Image;
                armtooltip.SetToolTip(this.HeroArmPic1, hero1.EquippedArmor.Description);
            }
            else
            {
                HeroArmPic1.Image = Properties.Resources.itembgarmor;
                armtooltip.SetToolTip(this.HeroArmPic1, "You do not have armor equipped");
            }
            
            if (hero1.Inventar.Slot[0]!=null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[0], HeroInventoryPic1, inventoryttip1);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic1, inventoryttip1);
            }

            if (hero1.Inventar.Slot[1] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[1], HeroInventoryPic2, inventoryttip2);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic2, inventoryttip2);
            }

            if (hero1.Inventar.Slot[2] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[2], HeroInventoryPic3, inventoryttip3);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic3, inventoryttip3);
            }

            if (hero1.Inventar.Slot[3] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[3], HeroInventoryPic4, inventoryttip4);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic4, inventoryttip4);
            }

            if (hero1.Inventar.Slot[4] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[4], HeroInventoryPic5, inventoryttip5);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic5, inventoryttip5);
            }

            if (hero1.Inventar.Slot[5] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[5], HeroInventoryPic6, inventoryttip6);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic6, inventoryttip6);
            }

            if (hero1.Inventar.Slot[6] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[6], HeroInventoryPic7, inventoryttip7);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic7, inventoryttip7);
            }

            if (hero1.Inventar.Slot[7] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[7], HeroInventoryPic8, inventoryttip8);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic8, inventoryttip8);
            }

            if (hero1.Inventar.Slot[8] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[8], HeroInventoryPic9, inventoryttip9);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic9, inventoryttip9);
            }

            if (hero1.Inventar.Slot[9] != null)
            {
                UpdateInventorySlot(hero1.Inventar.Slot[9], HeroInventoryPic10, inventoryttip10);
            }
            else
            {
                ClearInventorySlot(HeroInventoryPic10, inventoryttip10);
            }
        }

        void UpdateInventorySlot(Item item, PictureBox picture, ToolTip tip)
        {
            //update label and image of an inventory slot
            picture.Image = item.Image;          
            tip.Active = true;
            tip.SetToolTip(picture, item.Description);
        }

        void ClearInventorySlot(PictureBox picture, ToolTip tip)
        {
            //clear label and image of an inventory slot
            picture.Image = Properties.Resources.itembg;
            tip.Active = false;
        }


        private void HeroForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // hide form when form is closed
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        //individual methods for equipping items from inventory

        private void HeroInventoryPic1_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[0] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[0]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic2_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[1] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[1]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic3_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[2] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[2]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic4_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[3] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[3]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic5_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[4] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[4]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic6_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[5] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[5]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic7_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[6] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[6]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic8_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[7] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[7]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic9_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[8] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[8]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroInventoryPic10_Click(object sender, EventArgs e)
        {
            if (mainhero.Inventar.Slot[9] != null)
            {
                mainhero.EquipItemFromInventory(mainhero.Inventar.Slot[9]);
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroWpnPic1_Click(object sender, EventArgs e)
        {
            if(mainhero.Armed)
            {
                mainhero.Inventar.AddToInventory(mainhero.EquippedWeapon);
                mainhero.EquippedWeapon = null;
                mainhero.Armed = false;
                UpdateHeroPanel(mainhero);
            }
        }

        private void HeroArmPic1_Click(object sender, EventArgs e)
        {
            if(mainhero.Armored)
            {
                mainhero.Inventar.AddToInventory(mainhero.EquippedArmor);
                mainhero.EquippedArmor = null;
                mainhero.Armored = false;
                UpdateHeroPanel(mainhero);
            }

        }
    }
}
