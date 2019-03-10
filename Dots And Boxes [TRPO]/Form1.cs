﻿using System;
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
        static int player = 1;
        static int x, y, size = 5; //Переменные размеров поля и точки
        static Point[,] points;
        static Point[] line;
        static Point dot;

        private void dots() //Генерация точек
        {
            points = new Point[x * y, y * x];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    points[i, j] = new Point(i * ((pictureBox1.Width) / x) + ((pictureBox1.Width) / x) / 2 - size / 2, j * ((pictureBox1.Height) / y) + ((pictureBox1.Height) / y) / 2 - size / 2);
                }
        }

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

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            buttonColor1.Visible = true;
            buttonColor2.Visible = true;
            pictureBox1.Visible = true;
            labelScore1.Visible = true;
            labelScore2.Visible = true;
            labelScoreText.Visible = true;
            if (!Settings1.Default.FirstMovePlayer1)
                player = 2;
            else
                player = 1;
            labelMoveID.Text = "Ход игрока №" + player.ToString();
            labelMoveID.Visible = true;
            buttonBackToMenu.Visible = true;
            buttonRestart.Visible = true;
            buttonNewGame.Visible = false;
            buttonOptions.Visible = false;
            x = Settings1.Default.RowCount + 1;
            y = Settings1.Default.ColCount + 1;
            dots();
            pictureBox1.Invalidate();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            Form optionsForm = new Form2();
            optionsForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            buttonColor1.Visible = false;
            buttonColor2.Visible = false;
            pictureBox1.Visible = false;
            labelScore1.Visible = false;
            labelScore2.Visible = false;
            labelScoreText.Visible = false;
            labelMoveID.Visible = false;
            buttonBackToMenu.Visible = false;
            buttonRestart.Visible = false;
            buttonNewGame.Visible = true;
            buttonOptions.Visible = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    e.Graphics.DrawEllipse(pen, points[i, j].X, points[i, j].Y, size, size);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings1.Default.Save();
        }

       
    }
}
