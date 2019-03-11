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
            line = new Point[2];
            line[0] = new Point(0, 0);
            line[1] = new Point(0, 0);
        }
        static Color Color1, Color2;
        static int player = 1;
        static int x, y, size = 5; //Переменные размеров поля и точки
        static Point[,] points;
        static Point[] line;
        static Point dot;
        static int[,] arr;

        private void dots() //Генерация точек
        {
            points = new Point[x * y, y * x];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    points[i, j] = new Point(i * ((pictureBox1.Width) / x) + ((pictureBox1.Width) / x) / 2 - size / 2, j * ((pictureBox1.Height) / y) + ((pictureBox1.Height) / y) / 2 - size / 2);
                }
            //More tests
        }

        private void dotsCheck(int x_, int y_, int eX, int eY) //Подсветка
        {
            Point[] p = new Point[5];
            p[0] = points[x_, y_];
            p[1] = points[x_ + 1, y_];
            p[2] = points[x_, y_ + 1];
            p[3] = points[x_ + 1, y_ + 1];
            p[4] = new Point(points[x_, y_].X + (points[x_ + 1, y_ + 1].X - points[x_, y_].X) / 2, points[x_, y_].Y + (points[x_ + 1, y_ + 1].Y - points[x_, y_].Y) / 2);
            int a = (p[0].X - eX) * (p[1].Y - p[0].Y) - (p[1].X - p[0].X) * (p[0].Y - eY);
            int b = (p[1].X - eX) * (p[4].Y - p[1].Y) - (p[4].X - p[1].X) * (p[1].Y - eY);
            int c = (p[4].X - eX) * (p[0].Y - p[4].Y) - (p[0].X - p[4].X) * (p[4].Y - eY);

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = p[0];
                line[1] = p[1];
                dot = new Point(y_ * x + x_, y_ * x + x_ + 1);
                pictureBox1.Invalidate();
                return;
            }

            a = (p[0].X - eX) * (p[2].Y - p[0].Y) - (p[2].X - p[0].X) * (p[0].Y - eY);
            b = (p[2].X - eX) * (p[4].Y - p[2].Y) - (p[4].X - p[2].X) * (p[2].Y - eY);
            c = (p[4].X - eX) * (p[0].Y - p[4].Y) - (p[0].X - p[4].X) * (p[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = p[0];
                line[1] = p[2];
                dot = new Point(y_ * x + x_, (y_ + 1) * x + x_);
                pictureBox1.Invalidate();
                return;
            }
            a = (p[1].X - eX) * (p[3].Y - p[1].Y) - (p[3].X - p[1].X) * (p[1].Y - eY);
            b = (p[3].X - eX) * (p[4].Y - p[3].Y) - (p[4].X - p[3].X) * (p[3].Y - eY);
            c = (p[4].X - eX) * (p[1].Y - p[4].Y) - (p[1].X - p[4].X) * (p[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = p[1];
                line[1] = p[3];
                dot = new Point(y_ * x + x_ + 1, (y_ + 1) * x + x_ + 1);
                pictureBox1.Invalidate();
                return;
            }

            a = (p[2].X - eX) * (p[3].Y - p[2].Y) - (p[3].X - p[2].X) * (p[2].Y - eY);
            b = (p[3].X - eX) * (p[4].Y - p[3].Y) - (p[4].X - p[3].X) * (p[3].Y - eY);
            c = (p[4].X - eX) * (p[2].Y - p[4].Y) - (p[2].X - p[4].X) * (p[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = p[2];
                line[1] = p[3];
                dot = new Point((y_ + 1) * x + x_, (y_ + 1) * x + x_ + 1);
                pictureBox1.Invalidate();
                return;
            }
        }
        private void buttonColor1_Click(object sender, EventArgs e)
        {
           
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                Color1 = colorDialog1.Color;
                if (buttonColor2.BackColor != colorDialog1.Color)
                {
                    buttonColor1.BackColor = colorDialog1.Color;
                    Settings1.Default.Color1 = colorDialog1.Color;
                }
                   
                else MessageBox.Show("Этот цвет уже выбран Игроком 2");
            }
            
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            Color1 = colorDialog1.Color;
            if (buttonColor1.BackColor != colorDialog1.Color)
            {
                buttonColor2.BackColor = colorDialog1.Color;
                Settings1.Default.Color2 = colorDialog1.Color;
            }
            else MessageBox.Show("Этот цвет уже выбран Игроком 1");

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            buttonColor1.Visible = true;
            buttonColor1.BackColor = Settings1.Default.Color1;
            buttonColor2.Visible = true;
            buttonColor2.BackColor = Settings1.Default.Color2;
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
            arr = new int[x * y, y * x];
            dots();
            pictureBox1.Invalidate();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            Form optionsForm = new Form2();
            optionsForm.Show();
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x_ = 0, y_ = 0;
            for (int i = 1; i < x; i++)
                if (e.X > points[i - 1, 0].X && e.X < points[i, 0].X)
                    x_ = i - 1;
            for (int i = 1; i < y; i++)
                if (e.Y > points[0, i - 1].Y && e.Y < points[0, i].Y)
                    y_ = i - 1;
            dotsCheck(x_, y_, e.X, e.Y);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            arr = new int[x * y, y * x];
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);

            if (player == 1)
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, 2), line[0].X, line[0].Y, line[1].X, line[1].Y);
            else
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, 2), line[0].X, line[0].Y, line[1].X, line[1].Y);

            for (int i = 0; i < x * y; i++)
                for (int j = 0; j < x * y; j++)
                {
                    if (arr[i, j] == 1)
                        e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, 2), points[i % x, i / x], points[j % x, j / x]);
                    else if (arr[i, j] == 2)
                        e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, 2), points[i % x, i / x], points[j % x, j / x]);
                }

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    e.Graphics.DrawEllipse(pen, points[i, j].X, points[i, j].Y, size, size);    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (arr[dot.X, dot.Y] == 0)
            {
                arr[dot.X, dot.Y] = player;
                if (player == 1)
                    player++;
                else
                    player--;
                labelMoveID.Text = "Ход игрока №" + player.ToString();
                pictureBox1.Invalidate();
            }
                
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings1.Default.Save();
        }

       
    }
}
