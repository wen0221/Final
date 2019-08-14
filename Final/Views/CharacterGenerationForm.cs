using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Student Name:Wen Ma,
 Student ID:300903179

     */
namespace Final.Views
{
    public partial class CharacterGenerationForm : Form
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }
        public void GenerateNames()
        {
            Random name = new Random();
            
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        public void GenerateNumber()
        {
            Random Number = new Random();
            int number = Number.Next(1, 16);
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {

        }

        private void SkilltableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void GenerateRandomSkills()
        {
            Random Skill = new Random();

        }
        private void GenerateSkillsbutton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
