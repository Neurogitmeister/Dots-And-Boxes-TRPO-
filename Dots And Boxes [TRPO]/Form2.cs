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
        private void Form2_Load(object sender, EventArgs e)
        {
            trackBarCol.Value = Settings1.Default.ColCount;
            trackBarRows.Value = Settings1.Default.RowCount;

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

        private void buttonOptCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonOptApply_Click(object sender, EventArgs e)
        {
            Settings1.Default.ColCount = this.trackBarCol.Value;
            Settings1.Default.RowCount = this.trackBarRows.Value;

            if (this.radioPlayer1.Checked)
                Settings1.Default.FirstMovePlayer1 = true;
            else
                Settings1.Default.FirstMovePlayer1 = false;

            this.Hide();
        }
    }
}
