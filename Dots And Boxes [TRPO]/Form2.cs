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
                radioPlayer1.Enabled = false;
                radioPlayer2.Enabled = false;
            }
            else
            {
                trackBarCol.Enabled = true;
                trackBarRows.Enabled = true;
                radioPlayer1.Enabled = true;
                radioPlayer2.Enabled = true;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            trackBarCol.Value = Settings1.Default.ColCount;
            trackBarRows.Value = Settings1.Default.RowCount;
            trackBarDotSize.Value = Settings1.Default.DotSize;
            buttonDotsColor.BackColor = Settings1.Default.DotColor;
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
    }
}
