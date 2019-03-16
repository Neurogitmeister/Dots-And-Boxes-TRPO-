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
            line = new Point[4];
            line[0] = new Point(0, 0);
            line[1] = new Point(0, 0);          
        }
        static int player = 1;
        static int player1Score, player2Score;
        static int counter = 0;
        static int squareFlag = 0;
        static int x, y; //Variables of game field size
        static int dotSize = Settings1.Default.DotSize;  // Pixel size of dots
        static int bigDot, dotMargin;
        static Point[,] points;
        static Point[] line;
        static int[,] GameLogicArray;
        static bool settingsLocked;

        private void dots() //Generatig points
        {
            points = new Point[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    points[i, j] = new Point(i * (pictureBox1.Width / x) + (pictureBox1.Width / x) / 2, j * (pictureBox1.Height / y) + (pictureBox1.Height / y) / 2 );
                }
            //More tests
        }

        private void dotsCheck(int x_, int y_, int eX, int eY) //Подсветка
        {
            Point[] DotsCheckArray = new Point[5];
            DotsCheckArray[0] = points[x_, y_];
            DotsCheckArray[1] = points[x_ + 1, y_];
            DotsCheckArray[2] = points[x_, y_ + 1];
            DotsCheckArray[3] = points[x_ + 1, y_ + 1];
            DotsCheckArray[4] = new Point(points[x_, y_].X + (points[x_ + 1, y_ + 1].X - points[x_, y_].X) / 2, points[x_, y_].Y + (points[x_ + 1, y_ + 1].Y - points[x_, y_].Y) / 2);
            int a = (DotsCheckArray[0].X - eX) * (DotsCheckArray[1].Y - DotsCheckArray[0].Y) - (DotsCheckArray[1].X - DotsCheckArray[0].X) * (DotsCheckArray[0].Y - eY);
            int b = (DotsCheckArray[1].X - eX) * (DotsCheckArray[4].Y - DotsCheckArray[1].Y) - (DotsCheckArray[4].X - DotsCheckArray[1].X) * (DotsCheckArray[1].Y - eY);
            int c = (DotsCheckArray[4].X - eX) * (DotsCheckArray[0].Y - DotsCheckArray[4].Y) - (DotsCheckArray[0].X - DotsCheckArray[4].X) * (DotsCheckArray[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = DotsCheckArray[0];
                line[1] = DotsCheckArray[1];
                if ( !(line[0] == line[2] && line[1] == line[3]) )
                    pictureBox1.Invalidate();
                line[2] = line[0];
                line[3] = line[1];
                return;
            }

            a = (DotsCheckArray[0].X - eX) * (DotsCheckArray[2].Y - DotsCheckArray[0].Y) - (DotsCheckArray[2].X - DotsCheckArray[0].X) * (DotsCheckArray[0].Y - eY);
            b = (DotsCheckArray[2].X - eX) * (DotsCheckArray[4].Y - DotsCheckArray[2].Y) - (DotsCheckArray[4].X - DotsCheckArray[2].X) * (DotsCheckArray[2].Y - eY);
            c = (DotsCheckArray[4].X - eX) * (DotsCheckArray[0].Y - DotsCheckArray[4].Y) - (DotsCheckArray[0].X - DotsCheckArray[4].X) * (DotsCheckArray[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = DotsCheckArray[0];
                line[1] = DotsCheckArray[2];
                if (!(line[0] == line[2] && line[1] == line[3]))
                    pictureBox1.Invalidate();
                line[2] = line[0];
                line[3] = line[1];
                return;
            }
            a = (DotsCheckArray[1].X - eX) * (DotsCheckArray[3].Y - DotsCheckArray[1].Y) - (DotsCheckArray[3].X - DotsCheckArray[1].X) * (DotsCheckArray[1].Y - eY);
            b = (DotsCheckArray[3].X - eX) * (DotsCheckArray[4].Y - DotsCheckArray[3].Y) - (DotsCheckArray[4].X - DotsCheckArray[3].X) * (DotsCheckArray[3].Y - eY);
            c = (DotsCheckArray[4].X - eX) * (DotsCheckArray[1].Y - DotsCheckArray[4].Y) - (DotsCheckArray[1].X - DotsCheckArray[4].X) * (DotsCheckArray[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = DotsCheckArray[1];
                line[1] = DotsCheckArray[3];
                if (!(line[0] == line[2] && line[1] == line[3]))
                    pictureBox1.Invalidate();
                line[2] = line[0];
                line[3] = line[1];
                return;
            }

            a = (DotsCheckArray[2].X - eX) * (DotsCheckArray[3].Y - DotsCheckArray[2].Y) - (DotsCheckArray[3].X - DotsCheckArray[2].X) * (DotsCheckArray[2].Y - eY);
            b = (DotsCheckArray[3].X - eX) * (DotsCheckArray[4].Y - DotsCheckArray[3].Y) - (DotsCheckArray[4].X - DotsCheckArray[3].X) * (DotsCheckArray[3].Y - eY);
            c = (DotsCheckArray[4].X - eX) * (DotsCheckArray[2].Y - DotsCheckArray[4].Y) - (DotsCheckArray[2].X - DotsCheckArray[4].X) * (DotsCheckArray[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = DotsCheckArray[2];
                line[1] = DotsCheckArray[3];
                if (!(line[0] == line[2] && line[1] == line[3]))
                    pictureBox1.Invalidate();
                line[2] = line[0];
                line[3] = line[1];
                return;
            }
        }

        private void checkSquareComplete(int point1, int point2)
        {
            if (GameLogicArray[point1, 1] != 0 && GameLogicArray[point1, 2] != 0)
            {
                int test2 = Math.Min(GameLogicArray[point1 + x, 1], GameLogicArray[point1 + x, 2]);
                if (test2 == 0) test2 = Math.Max(GameLogicArray[point1 + x, 1], GameLogicArray[point1 + x, 2]);
                if (Math.Max(GameLogicArray[point1 + 1, 1], GameLogicArray[point1 + 1, 2]) == point1 + 1 + x && test2 == point1 + 1 + x && GameLogicArray[point1, 0] == 0)
                {
                    if (player == 1)
                    {
                        player1Score++;
                        GameLogicArray[point1, 0] = 1;
                    }
                    else
                    {
                        player2Score++;
                        GameLogicArray[point1, 0] = 2;
                    }
                    squareFlag = 1;
                    if (player1Score + player2Score == (x - 1) * (y - 1) )
                    {
                        pictureBox1.Invalidate();
                        GameOver(player1Score, player2Score);
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

        private void GameOver(int score1, int score2)
        {
            labelScore1.Text = player1Score.ToString();
            labelScore2.Text = player2Score.ToString();
            labelMoveID.Text = "Good Game!";
            if (score1 > score2)
                MessageBox.Show("Player 1 won! His/Her score: " + score1.ToString());
            else if (score2 > score1)
                MessageBox.Show("Player 2 won! His/Her score: " + score2.ToString());
            else
                MessageBox.Show("Tie! Magic score: " + score1.ToString());
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

        private void buttonDotsColor_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {             
                    buttonDotsColor.BackColor = colorDialog1.Color;
                    Settings1.Default.DotColor = colorDialog1.Color;
            }
            pictureBox1.Invalidate();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {          
            pictureBox1.Visible = true;
            //Labels
            labelName1.Visible = true;
            labelName1.ForeColor = Settings1.Default.Color1;
            labelName2.Visible = true;
            labelName2.ForeColor = Settings1.Default.Color2;
            labelScore1.Visible = true;
            labelScore2.Visible = true;
            labelScoreText.Visible = true;
            labelColourText.Visible = true;
            labelExtraColour.Visible = true;
            labelExtraColour2.Visible = true;
            if (!Settings1.Default.FirstMovePlayer1)
                player = 2;
            else
                player = 1;
            labelMoveID.Text = "Move of player №" + player.ToString();
            labelMoveID.Visible = true;
            labelDotsColor.Visible = true;
            //Buttons
            buttonContinue.Enabled = true;
            //buttonContinue.BackColor = Color.Firebrick;
            //buttonContinue.ForeColor = Color.SandyBrown;
            buttonContinue.Visible = false;
            buttonNewGame.Visible = false;
            buttonOptions.Visible = false;
            buttonBackToMenu.Visible = true;
            buttonRestart.Visible = true;
            buttonColor1.Visible = true;
            buttonColor1.BackColor = Settings1.Default.Color1;
            buttonColor2.Visible = true;
            buttonColor2.BackColor = Settings1.Default.Color2;
            buttonDotsColor.Visible = true;
            buttonDotsColor.BackColor = Settings1.Default.DotColor;
            buttonEndGame.Visible = true;
            //Loading values for variables
            dotSize = Settings1.Default.DotSize;
            x = Settings1.Default.ColCount + 1;
            y = Settings1.Default.RowCount + 1;
            bigDot = dotSize + dotSize * 3 / 4;
            if (bigDot % 2 == 0)
                bigDot++;
            if (bigDot < 10)
                dotMargin = 1;
            else
                dotMargin = 2;
            //Initialising the GameLogicArrayay
            GameLogicArray = new int[x * y, 5];

            dots();
            pictureBox1.Invalidate();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            if (buttonContinue.Enabled == true)
                settingsLocked = true;
            else
                settingsLocked = false;
            Form optionsForm = new Form2(settingsLocked);
            optionsForm.Show();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            buttonColor1.Visible = false;
            buttonColor2.Visible = false;
            buttonDotsColor.Visible = false;
            pictureBox1.Visible = false;
            labelName1.Visible = false;
            labelName2.Visible = false;
            labelScore2.Visible = false;
            labelScore1.Visible = false;
            labelColourText.Visible = false;
            labelExtraColour.Visible = false;
            labelExtraColour2.Visible = false;
            labelScoreText.Visible = false;
            labelMoveID.Visible = false;
            labelDotsColor.Visible = false;
            buttonBackToMenu.Visible = false;
            buttonRestart.Visible = false;
            buttonNewGame.Visible = true;
            buttonOptions.Visible = true;
            buttonContinue.Visible = true;
            buttonEndGame.Visible = false;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            //Labels
            labelName1.Visible = true;
            labelName1.ForeColor = Settings1.Default.Color1;
            labelName2.Visible = true;
            labelName2.ForeColor = Settings1.Default.Color2;
            labelScore1.Visible = true;
            labelScore2.Visible = true;
            labelScoreText.Visible = true;
            labelColourText.Visible = true;
            labelExtraColour.Visible = true;
            labelExtraColour2.Visible = true;
            labelMoveID.Visible = true;
            labelDotsColor.Visible = true;
            //Buttons
            buttonNewGame.Visible = false;
            buttonOptions.Visible = false;
            buttonBackToMenu.Visible = true;
            buttonRestart.Visible = true;
            buttonColor1.Visible = true;
            buttonColor1.BackColor = Settings1.Default.Color1;
            buttonColor2.Visible = true;
            buttonColor2.BackColor = Settings1.Default.Color2;
            buttonDotsColor.Visible = true;
            buttonDotsColor.BackColor = Settings1.Default.DotColor;
            buttonContinue.Visible = false;
            buttonEndGame.Visible = true;
            dotSize = Settings1.Default.DotSize;
            bigDot = dotSize + dotSize * 3 / 4;
            if (bigDot % 2 == 0)
                bigDot++;
            if (bigDot < 10)
                dotMargin = 1;
            else
                dotMargin = 2;
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            buttonRestart_Click(this, e);
            buttonBackToMenu_Click(this, e);
            buttonContinue.Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            GameLogicArray = new int[x * y, 5];
            if (Settings1.Default.FirstMovePlayer1)
                player = 1;
            else
                player = 2;
            player1Score = player2Score = 0;
            labelScore1.Text = "0";
            labelScore2.Text = "0";
            labelMoveID.Text = "Move of player №" + player.ToString();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush dotBrush = new SolidBrush(Settings1.Default.DotColor);
            
            if (player == 1)
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, dotSize), line[0].X, line[0].Y, line[1].X, line[1].Y);
            else
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, dotSize), line[0].X, line[0].Y, line[1].X, line[1].Y);

            for (int i = 0; i < x * y; i++)
                for (int j = 1; j <= 2; j++)
                {
                    if (GameLogicArray[i, j] != 0)
                    {
                        if (GameLogicArray[i, j + 2] == 1)
                            e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, dotSize), points[i % x, i / x], points[GameLogicArray[i,j] % x, GameLogicArray[i,j] / x]);

                        else
                            e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, dotSize), points[i % x, i / x], points[GameLogicArray[i,j] % x, GameLogicArray[i,j] / x]);                      
                    }
                }
            for (int i = 0; i < x * y; i++)
            {
                if (GameLogicArray[i,0] != 0)
                {
                    SolidBrush colorSquare;
                    if (GameLogicArray[i, 0] == 1)
                        colorSquare = new SolidBrush(Settings1.Default.Color1);
                    else
                        colorSquare = new SolidBrush(Settings1.Default.Color2);
                    e.Graphics.FillRectangle(colorSquare, i % x * (pictureBox1.Width / x) + pictureBox1.Width / x / 2 + dotSize / 2 + 3, i / x * (pictureBox1.Height / y) + pictureBox1.Height / y / 2 + dotSize / 2 + 3, pictureBox1.Width / x - dotSize - 4, pictureBox1.Height / y - dotSize - 4);
                }
            }
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    dotBrush.Color = Color.Black;
                    e.Graphics.FillEllipse(dotBrush, points[i, j].X - bigDot / 2 - 3, points[i, j].Y - bigDot / 2 - 3, bigDot + 5, bigDot + 5);
                    dotBrush.Color = Settings1.Default.DotColor;
                    e.Graphics.FillEllipse(dotBrush, points[i, j].X - bigDot / 2 - 1, points[i, j].Y - bigDot / 2 - 1, bigDot + 1, bigDot + 1);
                    dotBrush.Color = Color.Black;
                    e.Graphics.FillEllipse(dotBrush, points[i, j].X - (bigDot - 4) / 2 - 3 + dotMargin, points[i, j].Y - (bigDot - 4) / 2 - 3 + dotMargin, bigDot - dotMargin*2 + 1, bigDot - dotMargin*2 + 1);
                }
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
                if (GameLogicArray[pointNum1, j] == 0)
                {

                    if (line[0].X < line[1].X)
                        pointNum2 = pointNum1 + 1;
                    else
                        pointNum2 = pointNum1 + x;
                   if ( !(Math.Abs(GameLogicArray[pointNum1, 1] - pointNum2) == 0) )
                    {
                        
                        if (player == 2)
                            GameLogicArray[pointNum1, j + 2] = 2;
                        else
                            GameLogicArray[pointNum1, j + 2] = 1;
                        
                        GameLogicArray[pointNum1, j] = pointNum2;
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
