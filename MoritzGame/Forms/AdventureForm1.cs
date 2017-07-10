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

namespace MoritzGame.Forms
{
    public partial class AdventureForm1 : Form
    {
        private Adventure newadventure;
        private Form mainform;

        public AdventureForm1()
        {
            InitializeComponent();
        }

        internal Adventure InitializeAdventure(Adventure adventure1, Form form)
        {
            //if adventure already exists, give same adventure back, else give a new adventure back
            mainform = form;
            if (adventure1 == null)
            {
                newadventure = new Adventure();
                return newadventure;
            }
            else
            {
                newadventure = adventure1;
                return newadventure;
            }            
        }

        private void AdventureButton1_Click(object sender, EventArgs e)
        {
            //hide adventure form and show main form again
            this.Hide();
            mainform.Show();
        }

        private void AdventureButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
