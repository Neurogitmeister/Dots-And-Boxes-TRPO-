using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dots_And_Boxes__TRPO_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int lineSize = Settings1.Default.DotSize;  // Pixel size of lines
        static int coloredDotSize, dotMargin;   // Pixel sizes for dot and it's thickness
        static bool settingsLocked; // Gameplay settings locker for continue mode
        static Pen player1Pen = new Pen(Settings1.Default.Color1, lineSize);
        static Pen player2Pen = new Pen(Settings1.Default.Color2, lineSize);
        static SolidBrush blackDotBrush = new SolidBrush(Color.Black);
        static SolidBrush dotBrush = new SolidBrush(Settings1.Default.DotColor);
        static SolidBrush player1Square = new SolidBrush(Settings1.Default.Color1);
        static SolidBrush player2Square = new SolidBrush(Settings1.Default.Color2);
        private BusinessLogic logic;  // Game logics object

        private void GameOver() // Sequence to alert players about game being ended and to determine a winner.
        {
            labelScore1.Text = logic.player1Score.ToString();
            labelScore2.Text = logic.player2Score.ToString();
            labelMoveID.Text = "Good Game!";
            if (logic.player1Score > logic.player2Score)
            {
                logic.player1GamesWon++;
                MessageBox.Show("Player 1 won Game #" + logic.gameNum.ToString() + "! His/Her score: " + logic.player1Score.ToString() + ". Congratulations!");               
            }
            else if (logic.player2Score > logic.player1Score)
            {
                logic.player2GamesWon++;
                MessageBox.Show("Player 2 won Game #" + logic.gameNum.ToString() + "! His/Her score: " + logic.player2Score.ToString() + ". Congratulations!");
            }
            else
            {
                logic.player1GamesWon++;
                logic.player2GamesWon++;
                MessageBox.Show("Tie on Game #" + logic.gameNum.ToString() + "! Both winner's score: " + logic.player1Score.ToString() + ". Congratulations!");
            }
            if (logic.player1GamesWon == logic.gamesToWin && logic.player2GamesWon == logic.gamesToWin)
            {
                logic.gameNum--;
                MessageBox.Show("Match tie! " + Settings1.Default.Player1Name + "'s total score: " + logic.player1TotalScore.ToString() +
                    ". " + Settings1.Default.Player2Name + "'s total score: "+ logic.player2TotalScore.ToString() +". Well Done!");
                openScoreBoard(0);
            }
            else
                if (logic.player2GamesWon == logic.gamesToWin)
                {
                logic. gameNum--;
                    MessageBox.Show("Player 1 won the match! His/her total score: " + logic.player1TotalScore.ToString() + ". Well Done!");
                    openScoreBoard(1);                   
                }
                else 
                    if (logic.player2GamesWon == logic.gamesToWin)
                    {
                        logic.gameNum--;
                        MessageBox.Show("Player 2 won the match! His/her total score: " + logic.player2TotalScore.ToString() + ". Well Done!");
                        openScoreBoard(2);
                    }
            logic.gameNum++;
            labelGameNum.Text = "Game #" + logic.gameNum.ToString();
            labelGamesWon.Text = logic.player1GamesWon.ToString() + " : " + logic.player2GamesWon.ToString();
            refreshField();
        }

        private void refreshField()
        {
            logic.GameLogicArray = new int[logic.x * logic.y, 5];
            logic.player1Score = logic.player2Score = 0;
            labelScore1.Text = "0";
            labelScore2.Text = "0";
            pictureBox1.Invalidate();
        }

        public void gameScreenOpen()
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
            labelTotalScore.Visible = true;
            labelTotalScoreCaption.Visible = true;
            labelGamesWon.Visible = true;
            labelGamesWonCaption.Visible = true;
            labelGameNum.Visible = true;
            labelColourText.Visible = true;
            labelExtraColour.Visible = true;
            labelExtraColour2.Visible = true;
            labelMoveID.Visible = true;
            labelMoveCaption.Visible = true;
            labelDotsColor.Visible = true;
           
            // Buttons
            buttonBackToMenu.Visible = true;
            buttonRestart.Visible = true;
            buttonColor1.Visible = true;
            buttonColor2.Visible = true;
            buttonDotsColor.Visible = true;
            buttonEndGame.Visible = true;

            // Options menu changes
            buttonDotsColor.BackColor = Settings1.Default.DotColor;
            buttonColor2.BackColor = Settings1.Default.Color2;
            buttonColor1.BackColor = Settings1.Default.Color1;
            lineSize = Settings1.Default.DotSize;
            player1Pen.Width = lineSize;
            player2Pen.Width = lineSize;
            coloredDotSize = lineSize + lineSize * 3 / 4;
            if (coloredDotSize % 2 == 0)
                coloredDotSize++;
            if (coloredDotSize < 10)
                dotMargin = 1;
            else
                dotMargin = 2;
        }

        public void gameScreenClose()
        {
            buttonColor1.Visible = false;
            buttonColor2.Visible = false;
            buttonDotsColor.Visible = false;
            pictureBox1.Visible = false;
            labelName1.Visible = false;
            labelName2.Visible = false;
            labelScore2.Visible = false;
            labelScore1.Visible = false;
            labelTotalScore.Visible = false;
            labelTotalScoreCaption.Visible = false;
            labelGamesWon.Visible = false;
            labelGamesWonCaption.Visible = false;
            labelGameNum.Visible = false;
            labelColourText.Visible = false;
            labelExtraColour.Visible = false;
            labelExtraColour2.Visible = false;
            labelScoreText.Visible = false;
            labelMoveID.Visible = false;
            labelMoveCaption.Visible = false;
            labelDotsColor.Visible = false;
            buttonBackToMenu.Visible = false;
            buttonRestart.Visible = false;
            buttonEndGame.Visible = false;
        }
        public void menuScreenOpen()
        {
            buttonNewGame.Visible = true;
            buttonOptions.Visible = true;
            buttonContinue.Visible = true;         
        }

        public void menuScreenClose()
        {
            buttonNewGame.Visible = false;
            buttonOptions.Visible = false;
            buttonContinue.Visible = false;
        }

        private void openScoreBoard(int player)
        {
            logic.gameNum++;
            labelGameNum.Text = "Game #" + logic.gameNum.ToString();
            labelGamesWon.Text = logic.player1GamesWon.ToString() + " : " + logic.player2GamesWon.ToString();

            ScoreBoard board = new ScoreBoard();
            switch (player)
            {
                case 0:
                    board.ScoreAdd(Settings1.Default.Player1Name, logic.player1TotalScore, logic.x, logic.y, logic.player1GamesWon);
                    board.ScoreAdd(Settings1.Default.Player2Name, logic.player2TotalScore, logic.x, logic.y, logic.player2GamesWon);
                    break;
                case 1:
                    board.ScoreAdd(Settings1.Default.Player1Name, logic.player1TotalScore, logic.x, logic.y, logic.player1GamesWon);
                    break;
                case 2:
                    board.ScoreAdd(Settings1.Default.Player2Name, logic.player2TotalScore, logic.x, logic.y, logic.player2GamesWon);
                    break;
            }

            MessageBox.Show("");
            gameScreenClose();
            menuScreenOpen();
            buttonContinue.Enabled = false;
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
                    player1Pen.Color = colorDialog1.Color;
                    player1Square.Color = colorDialog1.Color;
                }                  
                else MessageBox.Show("This color has already been picked by Player 2");
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
                    player2Pen.Color = colorDialog1.Color;
                    player2Square.Color = colorDialog1.Color;
                }
                else MessageBox.Show("This color has already been picked by Player 1");
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
                dotBrush.Color = colorDialog1.Color;
            }
            pictureBox1.Invalidate();
        }

        private void buttonNewGame_Click(object sender, EventArgs e) // MenuScreen's New Game button actions on click
        {
            logic = new BusinessLogic();
            
            // Loading values for variables
            logic.gamesToWin = Settings1.Default.GamesToWin;
            logic.gameNum = 1;
            logic.player1GamesWon = 0;
            logic.player2GamesWon = 0;

            // Labels
            labelGameNum.Text = "Game #" + logic.gameNum.ToString();
            labelName1.Text = Settings1.Default.Player1Name;
            labelName1.ForeColor = Settings1.Default.Color1;
            labelName2.Text = Settings1.Default.Player2Name;
            labelName2.ForeColor = Settings1.Default.Color2;
           
            if (Settings1.Default.FirstMovePlayer1)
            {
                logic.player = 1;
                labelMoveID.Text = Settings1.Default.Player1Name.ToString();
                labelMoveID.ForeColor = Settings1.Default.Color1;
            }                
            else
            {
                logic.player = 2;
                labelMoveID.Text = Settings1.Default.Player2Name.ToString();
                labelMoveID.ForeColor = Settings1.Default.Color2;
            }               
           
            // Initialising the GameLogicArrayay
            logic.dots(pictureBox1.Width, pictureBox1.Height);
            
            // Opening game screen
            menuScreenClose();
            gameScreenOpen();
            buttonContinue.Enabled = true;
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
            gameScreenClose();
            menuScreenOpen();
        }

        private void buttonContinue_Click(object sender, EventArgs e) // MenuScreen's Continue button actions on click
        {
            menuScreenClose();
            gameScreenOpen();
        }

        private void buttonEndGame_Click(object sender, EventArgs e) // GameScreen's End Game button actions on click
        {
            gameScreenClose();
            menuScreenOpen();
            buttonContinue.Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e) // GameScreen's Restart button actions on click
        {
            if (Settings1.Default.FirstMovePlayer1)
            {
                logic.player = 1;
                labelMoveID.Text = Settings1.Default.Player1Name.ToString();
            }
                
            else
            {
                logic.player = 2;
                labelMoveID.Text = Settings1.Default.Player2Name.ToString();
            }
            logic.player1TotalScore -= logic.player1Score;
            logic.player2TotalScore -= logic.player2Score;
            refreshField();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) // Repaint actions for every time PictureBox1.Invalidate(); is called
        {         
            if (logic.player == 1) // Highlight the current chosen line
                e.Graphics.DrawLine(player1Pen, logic.lineOld[0].X, logic.lineOld[0].Y, logic.lineOld[1].X, logic.lineOld[1].Y);
            else
                e.Graphics.DrawLine(player2Pen, logic.lineOld[0].X, logic.lineOld[0].Y, logic.lineOld[1].X, logic.lineOld[1].Y);

            for (int i = 0; i < logic.x * logic.y; i++)  // Paint on all the lines written to GameLogicsArray's memory
                for (int j = 1; j <= 2; j++)
                {
                    if (logic.GameLogicArray[i, j] != 0)
                    {
                        if (logic.GameLogicArray[i, j + 2] == 1)
                            e.Graphics.DrawLine(player1Pen, logic.points[i % logic.x, i / logic.x], logic.points[logic.GameLogicArray[i,j] % logic.x, logic.GameLogicArray[i,j] / logic.x]);
                        else
                            e.Graphics.DrawLine(player2Pen, logic.points[i % logic.x, i / logic.x], logic.points[logic.GameLogicArray[i,j] % logic.x, logic.GameLogicArray[i,j] / logic.x]);                      
                    }
                }
            for (int i = 0; i < logic.x * logic.y; i++) // Paint on all the squares written to GameLogicArrray's memory
            {
                if (logic.GameLogicArray[i,0] != 0)
                {
                    if (logic.GameLogicArray[i, 0] == 1)
                        e.Graphics.FillRectangle(player1Square, i % logic.x * (pictureBox1.Width / logic.x) + pictureBox1.Width / logic.x / 2 + lineSize / 2 + 3, i / logic.x * (pictureBox1.Height / logic.y) + pictureBox1.Height / logic.y / 2 + lineSize / 2 + 3, pictureBox1.Width / logic.x - lineSize - 4, pictureBox1.Height / logic.y - lineSize - 4);
                    else
                        e.Graphics.FillRectangle(player2Square, i % logic.x * (pictureBox1.Width / logic.x) + pictureBox1.Width / logic.x / 2 + lineSize / 2 + 3, i / logic.x * (pictureBox1.Height / logic.y) + pictureBox1.Height / logic.y / 2 + lineSize / 2 + 3, pictureBox1.Width / logic.x - lineSize - 4, pictureBox1.Height / logic.y - lineSize - 4);
                }
            }
            for (int i = 0; i < logic.x; i++) // Paint on all the dots
                for (int j = 0; j < logic.y; j++)
                {
                    // Black outline
                    e.Graphics.FillEllipse(blackDotBrush, logic.points[i, j].X - coloredDotSize / 2 - 3, logic.points[i, j].Y - coloredDotSize / 2 - 3, coloredDotSize + 5, coloredDotSize + 5);
                    // Colored dot
                    e.Graphics.FillEllipse(dotBrush, logic.points[i, j].X - coloredDotSize / 2 - 1, logic.points[i, j].Y - coloredDotSize / 2 - 1, coloredDotSize + 1, coloredDotSize + 1);
                    // Inner hole 
                    e.Graphics.FillEllipse(blackDotBrush, logic.points[i, j].X - (coloredDotSize - 4) / 2 - 3 + dotMargin, logic.points[i, j].Y - (coloredDotSize - 4) / 2 - 3 + dotMargin, coloredDotSize - dotMargin*2 + 1, coloredDotSize - dotMargin*2 + 1);
                }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) // Action on cursor moving over PaintBox1
        {
            logic.indexTracker(e.X, e.Y);
            logic.dotsCheck(logic.index_x, logic.index_y, e.X, e.Y);
            if (!(logic.line[0] == logic.lineOld[0] && logic.line[1] == logic.lineOld[1]))
                pictureBox1.Invalidate();
            logic.lineOld[0] = logic.line[0];
            logic.lineOld[1] = logic.line[1];
        }

        private void pictureBox1_Click(object sender, EventArgs e) // PaintBox1's actions on click
        {

            // Obtaining first point's number from current remembered line's pixel coordinates
            int pointNum1 = logic.convertPixelsToPointNumber(pictureBox1.Width, pictureBox1.Height, logic.lineOld[0]);

            logic.checkAfterClick(pointNum1);

            if (logic.squareFlag != 0) // If square was found scores labels are updated
            {
                labelScore1.Text = logic.player1Score.ToString();
                labelScore2.Text = logic.player2Score.ToString();
                labelTotalScore.Text = logic.player1TotalScore.ToString() + " : " + logic.player2TotalScore.ToString();
            }
            if (!(logic.player1Score + logic.player2Score == (logic.x - 1) * (logic.y - 1))) // If game isn't over yet - update the move indication label
                if (logic.player == 1)
                {
                    labelMoveID.Text = Settings1.Default.Player1Name.ToString();
                    labelMoveID.ForeColor = Settings1.Default.Color1;
                }                  
                else
                {
                    labelMoveID.Text = Settings1.Default.Player2Name.ToString();
                    labelMoveID.ForeColor = Settings1.Default.Color2;
                }
                   
            else // Check for GameOver situation after every square is found
            {
                GameOver();
            }

            pictureBox1.Invalidate();         
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
            line = new Point[2]; // Stores current line position
            line[0] = new Point(0, 0);
            line[1] = new Point(0, 0);
            lineOld = new Point[2]; // Stores last placed line's position
            lineOld[0] = new Point(0, 0);
            lineOld[1] = new Point(0, 0);
            GameLogicArray = new int[x * y, 5];
        }
        public int player1Score, player2Score, player1TotalScore, player2TotalScore;
        public int player1GamesWon, player2GamesWon; // Games players have won
        public int gamesToWin, gameNum = 1; // Games one player should win to win a match and a number of the current game
        public int[,] GameLogicArray; // Initialize memory space for the Array's field 
        public int counter = 0; // Recursive function iterations counter
        public int squareFlag = 0; // Indicates that square was found after a line is placed
        public int player; // Number of a player to make the move
        public Point[] line;
        public Point[] lineOld;
        public Point[,] points; // Graphics array with pixel coordinates for each point
        public int x = Settings1.Default.ColCount + 1; // Number of points in a row
        public int y = Settings1.Default.RowCount + 1; // Number of points in a column
        public int a, b; // Vertical and horizontal pixel distance between dots
        public int index_x = 0, index_y = 0; // Index numbers to find a starting point of current line in Graphics array 

        public int convertPixelsToPointNumber(int width, int height, Point p) // Is used to determine point's number by it's pixel coordinates
        {
            int number = (p.Y - (height / y) / 2) / (height / y) * x + (p.X - (width / x) / 2) / (width / x);
            return number;
        }

        public void indexTracker(int cursorX, int cursorY) // Determines which square sector between points current cursor position belongs by finding indexes for future reference point
        {
            for (int i = 1; i < x; i++)
                if (cursorX >= points[i - 1, 0].X && cursorX < points[i, 0].X)
                    index_x = i - 1;
            for (int i = 1; i < y; i++)
                if (cursorY >= points[0, i - 1].Y && cursorY < points[0, i].Y)
                    index_y = i - 1;
        }

        public void checkAfterClick(int pointNum1) // Checks if line is going to be placed according to the rules and determines what to do after it's placed
        {
            int pointNum2;
            for (int j = 1; j <= 2; j++)
            {
                if (GameLogicArray[pointNum1, j] == 0)
                {
                    if (line[0].X < line[1].X) // Locating the current line's 2nd point's number
                        pointNum2 = pointNum1 + 1;
                    else
                        pointNum2 = pointNum1 + x;
                    if (!(Math.Abs(GameLogicArray[pointNum1, 1] - pointNum2) == 0)) // Check for not repainting the line
                    {
                        if (player == 2) // Writing the line's color in [..,3] or [..,4]
                            GameLogicArray[pointNum1, j + 2] = 2;
                        else
                            GameLogicArray[pointNum1, j + 2] = 1;

                        GameLogicArray[pointNum1, j] = pointNum2; // Writing the connected point to the column of index
                        squareFlag = 0; // Unchecking the SquareFound flag
                        checkSquareComplete(pointNum1, pointNum2); // Checking current line's points for square completions
                        if (squareFlag == 0) // If square wasn't found during the process turn is changed
                           if (player == 1)
                                player++;
                            else
                                player--;                   
                    }
                    break;
                }
            }
        }

        public void dots(int width, int height) // Generatig points
        {
            points = new Point[x, y];
            GameLogicArray = new int[x * y, 5];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    points[i, j] = new Point(i * (width / x) + (width / x) / 2, j * (height / y) + (height / y) / 2);
                }
        }

        public void dotsCheck(int index_x, int index_y, int eX, int eY) // Finding the points to write them into line and remember for further operations
        {
            b = points[1, 0].X - points[0, 0].X;
            a = points[0, 1].Y - points[0, 0].Y;
            if (eY - points[index_x, index_y].Y <= (points[index_x, index_y].X - eX )* a / b + a)
                if (eY - points[index_x, index_y].Y >= (eX - points[index_x, index_y].X) * a / b)
                {
                    line[0] = points[index_x, index_y];
                    line[1] = points[index_x, index_y + 1];
                }                       
                else
                {
                    line[0] = points[index_x, index_y];
                    line[1] = points[index_x + 1, index_y];
                }
            else 
                if (eY - points[index_x, index_y].Y >= (eX - points[index_x, index_y].X) * a / b)
                {
                    line[0] = points[index_x, index_y + 1];
                    line[1] = points[index_x + 1, index_y + 1];
                }
                else
                {
                    line[0] = points[index_x + 1, index_y];
                    line[1] = points[index_x + 1, index_y + 1];
                }
        }
        public void checkSquareComplete(int point1, int point2) // Check GameLogicArray if a 1x1 square of lines starting diagonally from point with number "point1" is complete.
        {
            if (GameLogicArray[point1, 1] != 0 && GameLogicArray[point1, 2] != 0)
            {
                int nextPoint = Math.Min(GameLogicArray[point1 + x, 1], GameLogicArray[point1 + x, 2]);
                if (nextPoint == 0)
                    nextPoint = Math.Max(GameLogicArray[point1 + x, 1], GameLogicArray[point1 + x, 2]);
                if (Math.Max(GameLogicArray[point1 + 1, 1], GameLogicArray[point1 + 1, 2]) == point1 + 1 + x && nextPoint == point1 + 1 + x && GameLogicArray[point1, 0] == 0) // Checking if points are connected in 1x1 square fashion
                {
                    if (player == 1)
                    {
                        player1Score++;
                        player1TotalScore++;
                        GameLogicArray[point1, 0] = 1;
                    }
                    else
                    {
                        player2Score++;
                        player2TotalScore++;
                        GameLogicArray[point1, 0] = 2;
                    }
                    squareFlag = 1;
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
    }

    public class ScoreBoard
    {
        public ScoreBoard()
        {
        }
        public ScoreBoard(string newPath)
        {
            path = newPath;
        }
        public string path = "scoreboard.txt";

        public void ScoreAdd(string name, int score, int rows, int cols, int gamesWon)
        {
            List<string> text;
            try
            {
                text = File.ReadAllLines(path).ToList();
                int boardSize = text.SelectMany(list => list).Count();
                string record;
                int counter = 0;
                int scoreCurr, gamesWonCurr, fieldSizeCurr;
                string nameCurr;
                record = text[counter];
                segmentRecordLine(record, out nameCurr, out fieldSizeCurr, out gamesWonCurr, out scoreCurr);

                while (rows * cols < fieldSizeCurr && counter != boardSize - 1)
                {
                    record = text[++counter];
                    segmentRecordLine(record, out nameCurr, out fieldSizeCurr, out gamesWonCurr, out scoreCurr);
                }

                while (gamesWon < gamesWonCurr && counter != boardSize - 1)
                {
                    record = text[++counter];
                    segmentRecordLine(record, out nameCurr, out fieldSizeCurr, out gamesWonCurr, out scoreCurr);
                }

                while (score < scoreCurr && counter != boardSize - 1)
                {
                    record = text[++counter];
                    segmentRecordLine(record, out nameCurr, out fieldSizeCurr, out gamesWonCurr, out scoreCurr);
                }
                text.Insert(counter, name.ToString() + " " + rows.ToString() + "x" + cols.ToString() + " " + gamesWon.ToString() + " " + score.ToString());
                File.WriteAllLines(path, text);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void segmentRecordLine(string record, out string name, out int fieldSize, out int gamesWon, out int score)
        {
            int i = record.Length;

            // Finding Total Score
            string tempValString = "";
            while (record[--i] != ' ')
                tempValString = record[i] + tempValString;
            score = int.Parse(tempValString);

            // Finding GamesWon
            tempValString = "";
            while (record[--i] != ' ')
                tempValString = record[i] + tempValString;
            gamesWon = int.Parse(tempValString);

            // Finding Field Size
            tempValString = "";
            while (record[--i] != 'x')
                tempValString = record[i] + tempValString;
            fieldSize = int.Parse(tempValString);
            tempValString = "";
            while (record[--i] != ' ')
                tempValString = record[i] + tempValString;
            fieldSize *= int.Parse(tempValString);

            // Finding name
            tempValString = "";
            while (i-- != 0)
                tempValString = record[i] + tempValString;
            name = tempValString;
        }
        public void ScoreSort()
        {
            try
            {
                var text = File.ReadAllLines(path).ToList();
                int boardSize = text.Count();
                string record;
                int counter = 0;
                int scoreCurr, gamesWonCurr, fieldSizeCurr;
                int scorePrev, gamesWonPrev, fieldSizePrev;
                string nameCurr;
                string namePrev;
                string sortTemp;

                for (int i = 0; i < boardSize; i++)
                    for (int j = 0; j < boardSize - i - 1 ; j++)
                    {
                        record = text[j];
                        segmentRecordLine(record, out namePrev, out fieldSizePrev, out gamesWonPrev, out scorePrev);
                        record = text[j + 1];
                        segmentRecordLine(record, out nameCurr, out fieldSizeCurr, out gamesWonCurr, out scoreCurr);
                        if (fieldSizeCurr > fieldSizePrev)
                        {
                            sortTemp = text[j + 1];
                            text[j + 1] = text[j];
                            text[j] = sortTemp;
                        }
                    }
                for (int i = 0; i < boardSize; i++)
                    for (int j = 0; j < boardSize - i - 1; j++)
                    {
                        record = text[j];
                        segmentRecordLine(record, out namePrev, out fieldSizePrev, out gamesWonPrev, out scorePrev);
                        record = text[j + 1];
                        segmentRecordLine(record, out nameCurr, out fieldSizeCurr, out gamesWonCurr, out scoreCurr);
                        if (fieldSizeCurr == fieldSizePrev && gamesWonCurr > gamesWonPrev)
                        {
                            sortTemp = text[j + 1];
                            text[j + 1] = text[j];
                            text[j] = sortTemp;
                        }
                    }
                for (int i = 0; i < boardSize; i++)
                    for (int j = 0; j < boardSize - i - 1; j++)
                    {
                        record = text[j];
                        segmentRecordLine(record, out namePrev, out fieldSizePrev, out gamesWonPrev, out scorePrev);
                        record = text[j + 1];
                        segmentRecordLine(record, out nameCurr, out fieldSizeCurr, out gamesWonCurr, out scoreCurr);
                        if (gamesWonCurr == gamesWonPrev && scoreCurr > scorePrev)
                        {
                            sortTemp = text[j + 1];
                            text[j + 1] = text[j];
                            text[j] = sortTemp;
                        }
                    } 

                File.WriteAllLines(path, text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
