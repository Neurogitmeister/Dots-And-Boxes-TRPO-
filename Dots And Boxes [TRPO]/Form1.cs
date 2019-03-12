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
        static int player = 1;
        static int player1Score, player2Score;
        static int counter = 0;
        static int squareFlag = 0;
        static int x, y, size = 8; //Переменные размеров поля и точки
        static Point[,] points;
        static Point[] line;
        static int[,] arr;

        private void dots() //Генерация точек
        {
            points = new Point[x * y, y * x];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    points[i, j] = new Point(i * (pictureBox1.Width / x) + (pictureBox1.Width / x) / 2, j * (pictureBox1.Height / y) + (pictureBox1.Height / y) / 2 );
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
                pictureBox1.Invalidate();
                return;
            }
        }

        private void checkSquareComplete(int point1, int point2)
        {
            if (arr[point1, 1] != 0 && arr[point1, 2] != 0)
            {
                int test2 = Math.Min(arr[point1 + x, 1], arr[point1 + x, 2]);
                if (test2 == 0) test2 = Math.Max(arr[point1 + x, 1], arr[point1 + x, 2]);
                if (Math.Max(arr[point1 + 1, 1], arr[point1 + 1, 2]) == point1 + 1 + x && test2 == point1 + 1 + x && arr[point1, 0] == 0)
                {
                    if (player == 1)
                    {
                        player1Score++;
                        arr[point1, 0] = 1;
                    }
                    else
                    {
                        player2Score++;
                        arr[point1, 0] = 2;
                    }
                    squareFlag = 1;
                    if (player1Score + player2Score == (x - 1) * (y - 1) )
                    {
                        pictureBox1.Invalidate();
                        if (player1Score > player2Score)
                            GameOver(1, player1Score);
                        else
                           if (player2Score > player1Score)
                            GameOver(2, player2Score);
                        else
                            GameOver(0, player1Score);
                    }
                       
                }
                else counter = 0;
            }
            counter++;
            if (counter > 1)
            {
                counter = 0;
                return;
            }
            if (point1 < x && point2 - point1 == 1 || point1 == 0)
            {
                counter = 0;
                return;
            }
            if (point2 - point1 > 1)
            {
                checkSquareComplete(point1 - 1, point1);
            }
  
            else
            {
                checkSquareComplete(point1 - x, point1);
            }
        }

        private void GameOver(int winner, int score)
        {
            labelScore1.Text = player1Score.ToString();
            labelScore2.Text = player2Score.ToString();
            labelMoveID.Text = "Good Game!";
            if (winner != 0)
                MessageBox.Show("Player " + winner.ToString() + " won! His/Her score: " + score.ToString());
            else
                MessageBox.Show("Tie! Magic score: " + score.ToString());
        }
        private void buttonColor1_Click(object sender, EventArgs e)
        {
           
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                if (buttonColor2.BackColor != colorDialog1.Color)
                {
                    buttonColor1.BackColor = colorDialog1.Color;
                    labelName1.ForeColor = colorDialog1.Color;
                    Settings1.Default.Color1 = colorDialog1.Color;
                    
                }
                   
                else MessageBox.Show("This colour has already been picked by Player 2");
            }
            pictureBox1.Invalidate();
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                if (buttonColor1.BackColor != colorDialog1.Color)
                {
                    buttonColor2.BackColor = colorDialog1.Color;
                    labelName2.ForeColor = colorDialog1.Color;
                    Settings1.Default.Color2 = colorDialog1.Color;
                   
                }
                else MessageBox.Show("This colour has already been picked by Player 1");
                pictureBox1.Invalidate();
            }
        }
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            buttonColor1.Visible = true;
            buttonColor1.BackColor = Settings1.Default.Color1;
            buttonColor2.Visible = true;
            buttonColor2.BackColor = Settings1.Default.Color2;

            pictureBox1.Visible = true;
            labelName1.Visible = true;
            labelName1.ForeColor = Settings1.Default.Color1;
            labelName2.Visible = true;
            labelName2.ForeColor = Settings1.Default.Color2;
            labelScore1.Visible = true;
            labelScore2.Visible = true;
            labelScoreText.Visible = true;
            labelColourText.Visible = true;
            labelExtraColour.Visible = true;
            if (!Settings1.Default.FirstMovePlayer1)
                player = 2;
            else
                player = 1;
            labelMoveID.Text = "Move of player №" + player.ToString();
            labelMoveID.Visible = true;
            buttonBackToMenu.Visible = true;
            buttonRestart.Visible = true;
            buttonNewGame.Visible = false;
            buttonOptions.Visible = false;
            x = Settings1.Default.ColCount + 1;
            y = Settings1.Default.RowCount + 1;

            arr = new int[x * y, 5];
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
            labelName1.Visible = false;
            labelName2.Visible = false;
            labelScore2.Visible = false;
            labelScore1.Visible = false;
            labelColourText.Visible = false;
            labelExtraColour.Visible = false;
            labelScoreText.Visible = false;
            labelMoveID.Visible = false;
            buttonBackToMenu.Visible = false;
            buttonRestart.Visible = false;
            buttonNewGame.Visible = true;
            buttonOptions.Visible = true;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            arr = new int[x * y, 5];
            if (Settings1.Default.FirstMovePlayer1)
                player = 1;
            else
                player = 2;
            player1Score = player2Score = 0;
            labelScore1.Text = "0";
            labelScore2.Text = "0";
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            
            if (player == 1)
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, size), line[0].X, line[0].Y, line[1].X, line[1].Y);
            else
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, size), line[0].X, line[0].Y, line[1].X, line[1].Y);

            for (int i = 0; i < x * y; i++)
                for (int j = 1; j <= 2; j++)
                {
                    if (arr[i, j] != 0)
                    {
                        if (arr[i, j + 2] == 1)
                            e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, size), points[i % x, i / x], points[arr[i,j] % x, arr[i,j] / x]);

                        else
                            e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, size), points[i % x, i / x], points[arr[i,j] % x, arr[i,j] / x]);
                       
                    }
                    
                }
            for (int i = 0; i < x * y; i++)
            {
                if (arr[i,0] != 0)
                {
                    SolidBrush colorSquare;
                    if (arr[i, 0] == 1)
                        colorSquare = new SolidBrush(Settings1.Default.Color1);
                    else
                        colorSquare = new SolidBrush(Settings1.Default.Color2);
                    e.Graphics.FillRectangle(colorSquare, i % x * (pictureBox1.Width / x) + pictureBox1.Width / x / 2 + size / 2 + 2, i / x * (pictureBox1.Height / y) + pictureBox1.Height / y / 2 + size / 2 + 2, pictureBox1.Width / x - size - 4, pictureBox1.Height / y - size - 4);
                }
            }
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    e.Graphics.DrawEllipse(pen, points[i, j].X - size / 2, points[i, j].Y - size / 2, size, size);    
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int pointNum1 = (line[0].Y - (pictureBox1.Height / y) / 2 ) / (pictureBox1.Height / y) * x + (line[0].X - (pictureBox1.Width / x) / 2 ) / (pictureBox1.Width / x);
            int pointNum2;

            for (int j = 1; j <= 2; j++)
            {
                if (arr[pointNum1, j] == 0)
                {

                    if (line[0].X < line[1].X)
                        pointNum2 = pointNum1 + 1;
                    else
                        pointNum2 = pointNum1 + x;
                   if ( !(Math.Abs(arr[pointNum1, 1] - pointNum2) == 0) )
                    {
                        
                        if (player == 2)
                            arr[pointNum1, j + 2] = 2;
                        else
                            arr[pointNum1, j + 2] = 1;
                        
                        arr[pointNum1, j] = pointNum2;
                        squareFlag = 0;
                        checkSquareComplete(pointNum1, pointNum2);
                        if (squareFlag == 0)
                            if (player == 1)
                                player++;
                            else
                                player--;
                        else
                        {
                            labelScore1.Text = player1Score.ToString();
                            labelScore2.Text = player2Score.ToString();
                        }
                        if ( !(player1Score + player2Score == (x - 1) * (y - 1) ) )
                        labelMoveID.Text = "Move of player №" + player.ToString();
                        pictureBox1.Invalidate();
                    }

                    
                    pictureBox1.Invalidate();
                    break;
                }           
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings1.Default.Save();
        }

       
    }
}
