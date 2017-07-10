using MoritzGame.Forms;
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

namespace MoritzGame
{
    public partial class MainWindow : Form
    {
        private Hero hero1;
        private Adventure adventure1;
        private HeroForm1 heroform = new HeroForm1();
        private AdventureForm1 adventureform = new AdventureForm1();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void MainButton1_Click(object sender, EventArgs e)
        {
            //create a new hero or keep already created hero and show hero form
            hero1 = heroform.InitializeHero(hero1, this);
            heroform.Show();
            this.Hide();
        }

        public void MainButton2_Click(object sender, EventArgs e)
        {
            //create a new adventure or keep already created adventure and show adventure form
            adventure1 = adventureform.InitializeAdventure(adventure1, this);     
            adventureform.Show();
            adventure1.BasicItems(hero1);
            this.Hide();
        }        
    }
}
