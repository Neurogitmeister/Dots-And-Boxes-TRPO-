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
            logic = new BusinessLogic();

        }
        static int player = 1;
        static int player1Score, player2Score;
        static int counter = 0;
        static int squareFlag = 0;
        static int x, y; // Variables of game field size
        static int lineSize = Settings1.Default.DotSize;  // Pixel size of dots
        static int coloredDotSize, dotMargin;
        static Point[] line;
        static int[,] GameLogicArray;
        static bool settingsLocked;
        BusinessLogic logic;

        

        private void checkSquareComplete(int point1, int point2) // Check GameLogicArray if a 1x1 square of lines starting diagonally from point with number "point1" is complete.
        {
            if (GameLogicArray[point1, 1] != 0 && GameLogicArray[point1, 2] != 0)
            {
                int nextPoint = Math.Min(GameLogicArray[point1 + x, 1], GameLogicArray[point1 + x, 2]);
                if (nextPoint == 0)
                    nextPoint = Math.Max(GameLogicArray[point1 + x, 1], GameLogicArray[point1 + x, 2]);
                if (Math.Max(GameLogicArray[point1 + 1, 1], GameLogicArray[point1 + 1, 2]) == point1 + 1 + x && nextPoint == point1 + 1 + x && GameLogicArray[point1, 0] == 0) // Checking if p0ints are connected in 1x1 square fashion
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
                    if (player1Score + player2Score == (x - 1) * (y - 1) ) // Check for GameOver situation after every square is found
                    {
                        pictureBox1.Invalidate();
                        GameOver(player1Score, player2Score);
                    }
                       
                }
                else counter = 0;
            }
            counter++; // Using the counter for recursion to make sure the function doesn't run more than 2 times
            if (counter > 1)
            {
                counter = 0;
                return;
            }

            if (point1 < x && point2 - point1 == 1 || point1 == 0) // Rules that don't allow recursively checking above and left of the first row
            {
                counter = 0;
                return;
            }

            if (point2 - point1 > 1) // Finding the next square to check recursively
            {
                checkSquareComplete(point1 - 1, point1);
            }
            else
            {
                checkSquareComplete(point1 - x, point1);
            }
        }

        private void GameOver(int score1, int score2) // Sequence to alert players about game being ended and to determine a winner.
        {
            labelScore1.Text = player1Score.ToString();
            labelScore2.Text = player2Score.ToString();
            labelMoveID.Text = "Good Game!";
            if (score1 > score2)
                MessageBox.Show("Player 1 won! His/Her score: " + score1.ToString() + ". Congratulations!");
            else if (score2 > score1)
                MessageBox.Show("Player 2 won! His/Her score: " + score2.ToString() + ". Congratulations!");
            else
                MessageBox.Show("Tie! Both winner's score: " + score1.ToString() + ". Congratulations!");
        }
        private void buttonColor1_Click(object sender, EventArgs e) // GameScreen's Player 1 Color select button
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

        private void buttonColor2_Click(object sender, EventArgs e) // GameScreen's Player 2 Color select button actions on click
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

        private void buttonDotsColor_Click(object sender, EventArgs e) // GameScreen's Dot Color select button actions on click
        {
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {             
                    buttonDotsColor.BackColor = colorDialog1.Color;
                    Settings1.Default.DotColor = colorDialog1.Color;
            }
            pictureBox1.Invalidate();
        }

        private void buttonNewGame_Click(object sender, EventArgs e) // MenuScreen's New Game button actions on click
        {          
            pictureBox1.Visible = true;
            // Labels
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
            // Buttons
            buttonContinue.Enabled = true;
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
            // Loading values for variables
            lineSize = Settings1.Default.DotSize;
            x = Settings1.Default.ColCount + 1;
            y = Settings1.Default.RowCount + 1;
            coloredDotSize = lineSize + lineSize * 3 / 4;
            if (coloredDotSize % 2 == 0)
                coloredDotSize++;
            if (coloredDotSize < 10)
                dotMargin = 1;
            else
                dotMargin = 2;
            // Initialising the GameLogicArrayay
            GameLogicArray = new int[x * y, 5];

            logic.dots(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Invalidate();
        }

        private void buttonOptions_Click(object sender, EventArgs e) // MenuScreen Option's button actions on click
        {
            if (buttonContinue.Enabled == true)
                settingsLocked = true;
            else
                settingsLocked = false;
            Form optionsForm = new Form2(settingsLocked);
            optionsForm.Show();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e) // GameScreen's Back To Menu button actions on click
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

        private void buttonContinue_Click(object sender, EventArgs e) // MenuScreen's Continue button actions on click
        {
            pictureBox1.Visible = true;
            // Labels
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
            // Buttons
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
            lineSize = Settings1.Default.DotSize;
            coloredDotSize = lineSize + lineSize * 3 / 4;
            if (coloredDotSize % 2 == 0)
                coloredDotSize++;
            if (coloredDotSize < 10)
                dotMargin = 1;
            else
                dotMargin = 2;
        }

        private void buttonEndGame_Click(object sender, EventArgs e) // GameScreen's End Game button actions on click
        {
            buttonRestart_Click(this, e);
            buttonBackToMenu_Click(this, e);
            buttonContinue.Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e) // GameScreen's Restart button actions on click
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e) // Repaint actions for every time PictureBox1.Invalidate(); is called
        {
            SolidBrush dotBrush = new SolidBrush(Settings1.Default.DotColor);
            
            if (player == 1) // Highlight the current chosen line
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, lineSize), line[0].X, line[0].Y, line[1].X, line[1].Y);
            else
                e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, lineSize), line[0].X, line[0].Y, line[1].X, line[1].Y);

            for (int i = 0; i < x * y; i++)  // Paint on all the lines written to GameLogicsArray's memory
                for (int j = 1; j <= 2; j++)
                {
                    if (GameLogicArray[i, j] != 0)
                    {
                        if (GameLogicArray[i, j + 2] == 1)
                            e.Graphics.DrawLine(new Pen(Settings1.Default.Color1, lineSize), logic.points[i % x, i / x], logic.points[GameLogicArray[i,j] % x, GameLogicArray[i,j] / x]);

                        else
                            e.Graphics.DrawLine(new Pen(Settings1.Default.Color2, lineSize), logic.points[i % x, i / x], logic.points[GameLogicArray[i,j] % x, GameLogicArray[i,j] / x]);                      
                    }
                }
            for (int i = 0; i < x * y; i++) // Paint on all the squares written to GameLogicArrray's memory
            {
                if (GameLogicArray[i,0] != 0)
                {
                    SolidBrush colorSquare;
                    if (GameLogicArray[i, 0] == 1)
                        colorSquare = new SolidBrush(Settings1.Default.Color1);
                    else
                        colorSquare = new SolidBrush(Settings1.Default.Color2);
                    e.Graphics.FillRectangle(colorSquare, i % x * (pictureBox1.Width / x) + pictureBox1.Width / x / 2 + lineSize / 2 + 3, i / x * (pictureBox1.Height / y) + pictureBox1.Height / y / 2 + lineSize / 2 + 3, pictureBox1.Width / x - lineSize - 4, pictureBox1.Height / y - lineSize - 4);
                }
            }
            for (int i = 0; i < x; i++) // Paint on all the dots
                for (int j = 0; j < y; j++)
                {
                    // Black outline
                    dotBrush.Color = Color.Black; 
                    e.Graphics.FillEllipse(dotBrush, logic.points[i, j].X - coloredDotSize / 2 - 3, logic.points[i, j].Y - coloredDotSize / 2 - 3, coloredDotSize + 5, coloredDotSize + 5);
                    // Colored dot
                    dotBrush.Color = Settings1.Default.DotColor; 
                    e.Graphics.FillEllipse(dotBrush, logic.points[i, j].X - coloredDotSize / 2 - 1, logic.points[i, j].Y - coloredDotSize / 2 - 1, coloredDotSize + 1, coloredDotSize + 1);
                    // Inner hole
                    dotBrush.Color = Color.Black; 
                    e.Graphics.FillEllipse(dotBrush, logic.points[i, j].X - (coloredDotSize - 4) / 2 - 3 + dotMargin, logic.points[i, j].Y - (coloredDotSize - 4) / 2 - 3 + dotMargin, coloredDotSize - dotMargin*2 + 1, coloredDotSize - dotMargin*2 + 1);
                }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) // Action on cursor moving over PaintBox1
        {
            int x_ = 0, y_ = 0;
            for (int i = 1; i < x; i++)
                if (e.X > logic.points[i - 1, 0].X && e.X < logic.points[i, 0].X)
                    x_ = i - 1;
            for (int i = 1; i < y; i++)
                if (e.Y > logic.points[0, i - 1].Y && e.Y < logic.points[0, i].Y)
                    y_ = i - 1;
            logic.dotsCheck(x_, y_, e.X, e.Y);
            if (!(logic.line[0] == line[0] && logic.line[1] == line[1]))
                pictureBox1.Invalidate();
            line[0] = logic.line[0];
            line[1] = logic.line[1];
        }

        private void pictureBox1_Click(object sender, EventArgs e) // PaintBox1's actions on click
        {
            // Obtaining first point's number from current remembered line's pixel coordinates
            int pointNum1 = (line[0].Y - (pictureBox1.Height / y) / 2 ) / (pictureBox1.Height / y) * x + (line[0].X - (pictureBox1.Width / x) / 2 ) / (pictureBox1.Width / x);
            int pointNum2;

            for (int j = 1; j <= 2; j++)
            {
                if (GameLogicArray[pointNum1, j] == 0)
                {
                    if (line[0].X < line[1].X) // Locating the 2nd point's number
                        pointNum2 = pointNum1 + 1;
                    else
                        pointNum2 = pointNum1 + x;
                   if ( !(Math.Abs(GameLogicArray[pointNum1, 1] - pointNum2) == 0) ) // Check for not repeinting the line
                    {                       
                        if (player == 2) // Writing the line's color in [..,3] or [..,4]
                            GameLogicArray[pointNum1, j + 2] = 2;
                        else
                            GameLogicArray[pointNum1, j + 2] = 1;
                        
                        GameLogicArray[pointNum1, j] = pointNum2; // Writing the connected point to the column of index
                        squareFlag = 0; // Unchecking the SquareFound flag
                        checkSquareComplete(pointNum1, pointNum2); // Checking current line's p0ints for square completions
                        if (squareFlag == 0) // If square wasn't found during the process turn is changed
                            if (player == 1)
                                player++;
                            else
                                player--;
                        else // If square was found scores labels are updated
                        {
                            labelScore1.Text = player1Score.ToString();
                            labelScore2.Text = player2Score.ToString();
                        }
                        if ( !(player1Score + player2Score == (x - 1) * (y - 1) ) ) // If game isn't over yet - update the move indication label
                        labelMoveID.Text = "Move of player №" + player.ToString();
                    }                   
                    pictureBox1.Invalidate();
                    break;
                }           
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // Actions on pressing the close button on main form
        {
            Settings1.Default.Save();
        }
      
    }
    public class BusinessLogic
    {
        public BusinessLogic()
        {
            line = new Point[2];
            line[0] = new Point(0, 0);
            line[1] = new Point(0, 0);
        }
        public Point[] line;
        public Point[,] points;
        static int x = Settings1.Default.ColCount + 1;
        static int y = Settings1.Default.RowCount + 1;
        public void dots(int width, int height) // Generatig p0ints
        {
           points = new Point[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    points[i, j] = new Point(i * (width / x) + (width / x) / 2, j * (height / y) + (height / y) / 2);
                }
        }

        public void dotsCheck(int x_, int y_, int eX, int eY) // Finding the points to write them into line and remember for further operations
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
                return;
            }

            a = (DotsCheckArray[0].X - eX) * (DotsCheckArray[2].Y - DotsCheckArray[0].Y) - (DotsCheckArray[2].X - DotsCheckArray[0].X) * (DotsCheckArray[0].Y - eY);
            b = (DotsCheckArray[2].X - eX) * (DotsCheckArray[4].Y - DotsCheckArray[2].Y) - (DotsCheckArray[4].X - DotsCheckArray[2].X) * (DotsCheckArray[2].Y - eY);
            c = (DotsCheckArray[4].X - eX) * (DotsCheckArray[0].Y - DotsCheckArray[4].Y) - (DotsCheckArray[0].X - DotsCheckArray[4].X) * (DotsCheckArray[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = DotsCheckArray[0];
                line[1] = DotsCheckArray[2];
                return;
            }
            a = (DotsCheckArray[1].X - eX) * (DotsCheckArray[3].Y - DotsCheckArray[1].Y) - (DotsCheckArray[3].X - DotsCheckArray[1].X) * (DotsCheckArray[1].Y - eY);
            b = (DotsCheckArray[3].X - eX) * (DotsCheckArray[4].Y - DotsCheckArray[3].Y) - (DotsCheckArray[4].X - DotsCheckArray[3].X) * (DotsCheckArray[3].Y - eY);
            c = (DotsCheckArray[4].X - eX) * (DotsCheckArray[1].Y - DotsCheckArray[4].Y) - (DotsCheckArray[1].X - DotsCheckArray[4].X) * (DotsCheckArray[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = DotsCheckArray[1];
                line[1] = DotsCheckArray[3];
                return;
            }

            a = (DotsCheckArray[2].X - eX) * (DotsCheckArray[3].Y - DotsCheckArray[2].Y) - (DotsCheckArray[3].X - DotsCheckArray[2].X) * (DotsCheckArray[2].Y - eY);
            b = (DotsCheckArray[3].X - eX) * (DotsCheckArray[4].Y - DotsCheckArray[3].Y) - (DotsCheckArray[4].X - DotsCheckArray[3].X) * (DotsCheckArray[3].Y - eY);
            c = (DotsCheckArray[4].X - eX) * (DotsCheckArray[2].Y - DotsCheckArray[4].Y) - (DotsCheckArray[2].X - DotsCheckArray[4].X) * (DotsCheckArray[4].Y - eY);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                line[0] = DotsCheckArray[2];
                line[1] = DotsCheckArray[3];
                return;
            }
        }
    }
}
