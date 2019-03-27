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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(bool settingsLocked)
        {
            InitializeComponent();
            if (settingsLocked)
            {
                trackBarCol.Enabled = false;
                trackBarRows.Enabled = false;
                trackBarGames.Enabled = false;
                radioPlayer1.Enabled = false;
                radioPlayer2.Enabled = false;
                player1NameBox.Enabled = false;
                player2NameBox.Enabled = false;
            }
            else
            {
                trackBarCol.Enabled = true;
                trackBarRows.Enabled = true;
                trackBarGames.Enabled = true;
                radioPlayer1.Enabled = true;
                radioPlayer2.Enabled = true;
                player1NameBox.Enabled = true;
                player2NameBox.Enabled = true;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            trackBarCol.Value = Settings1.Default.ColCount;
            trackBarRows.Value = Settings1.Default.RowCount;
            trackBarDotSize.Value = Settings1.Default.DotSize;
            buttonDotsColor.BackColor = Settings1.Default.DotColor;
            player1NameBox.Text = Settings1.Default.Player1Name;
            radioPlayer1.Text = Settings1.Default.Player1Name;
            player2NameBox.Text = Settings1.Default.Player2Name;
            radioPlayer2.Text = Settings1.Default.Player2Name;
            trackBarGames.Value = Settings1.Default.GamesToWin;

            if (Settings1.Default.FirstMovePlayer1)
                radioPlayer1.Checked = true;
            else
                radioPlayer2.Checked = true;
        }

        private void trackBarCol_ValueChanged(object sender, EventArgs e)
        {
            labelColCount.Text = trackBarCol.Value.ToString();
        }

        private void trackBarRows_ValueChanged(object sender, EventArgs e)
        {
            labelRowCount.Text = trackBarRows.Value.ToString();
        }

        private void trackBarDotSize_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarDotSize.Value % 2 == 0)
                trackBarDotSize.Value = trackBarDotSize.Value + 1;
            labelDotSizeVal.Text = trackBarDotSize.Value.ToString();
           
        }

        private void buttonOptCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonOptApply_Click(object sender, EventArgs e)
        {
            Settings1.Default.ColCount = this.trackBarCol.Value;
            Settings1.Default.RowCount = this.trackBarRows.Value;
            Settings1.Default.DotSize = this.trackBarDotSize.Value;
            Settings1.Default.Player1Name = this.player1NameBox.Text;
            Settings1.Default.Player2Name = this.player2NameBox.Text;
            Settings1.Default.GamesToWin = this.trackBarGames.Value;
            if (this.radioPlayer1.Checked)
                Settings1.Default.FirstMovePlayer1 = true;
            else
                Settings1.Default.FirstMovePlayer1 = false;

            this.Hide();
        }

        private void buttonDotsColor_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                buttonDotsColor.BackColor = colorDialog1.Color;
                Settings1.Default.DotColor = colorDialog1.Color;
            }
        }

        private void player1NameBox_TextChanged(object sender, EventArgs e)
        {
            if (player1NameBox.Text == player2NameBox.Text)
            {
                MessageBox.Show("Name is already occupied!");
            }               
            radioPlayer1.Text = player1NameBox.Text;
        }

        private void player2NameBox_TextChanged(object sender, EventArgs e)
        {
            if (player1NameBox.Text == player2NameBox.Text)
            {
                MessageBox.Show("Name is already occupied!");
            }
            radioPlayer2.Text = player2NameBox.Text;
        }

        private void trackBarGames_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarGames.Value % 2 == 0)
                trackBarGames.Value = trackBarGames.Value + 1;
            labelGamesToWin.Text = trackBarGames.Value.ToString();
        }
    }
}
