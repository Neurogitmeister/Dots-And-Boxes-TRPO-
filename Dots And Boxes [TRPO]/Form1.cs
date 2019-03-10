using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dots_And_Boxes__TRPO_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Color Color1, Color2;

        private void buttonColor1_Click(object sender, EventArgs e)
        {
           
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                Color1 = colorDialog1.Color;
                if (buttonColor2.BackColor != Color1)
                    buttonColor1.BackColor = Color1;

                else MessageBox.Show("Этот цвет уже выбран Игроком 2");
            }
            
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {

        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {

        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                Color2 = colorDialog1.Color;
                if (buttonColor1.BackColor != Color2)
                    buttonColor2.BackColor = Color2;
                else MessageBox.Show("Этот цвет уже выбран Игроком 1");
            }
           
        }
    }
}
