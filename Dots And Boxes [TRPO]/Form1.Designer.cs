﻿namespace Dots_And_Boxes__TRPO_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMoveID = new System.Windows.Forms.Label();
            this.labelScoreText = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor1 = new System.Windows.Forms.Button();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.labelColourText = new System.Windows.Forms.Label();
            this.labelExtraColour = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.buttonDotsColor = new System.Windows.Forms.Button();
            this.labelDotsColor = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelExtraColour2 = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.labelGamesWonCaption = new System.Windows.Forms.Label();
            this.labelTotalScoreCaption = new System.Windows.Forms.Label();
            this.labelTotalScore = new System.Windows.Forms.Label();
            this.labelGamesWon = new System.Windows.Forms.Label();
            this.labelGameNum = new System.Windows.Forms.Label();
            this.labelMoveCaption = new System.Windows.Forms.Label();
            this.labelGamesToWin = new System.Windows.Forms.Label();
            this.labelNeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // labelMoveID
            // 
            this.labelMoveID.BackColor = System.Drawing.Color.Transparent;
            this.labelMoveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoveID.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelMoveID.Location = new System.Drawing.Point(505, 24);
            this.labelMoveID.Name = "labelMoveID";
            this.labelMoveID.Size = new System.Drawing.Size(175, 24);
            this.labelMoveID.TabIndex = 2;
            this.labelMoveID.Text = "Nastya";
            this.labelMoveID.Visible = false;
            // 
            // labelScoreText
            // 
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.BackColor = System.Drawing.Color.Transparent;
            this.labelScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelScoreText.Location = new System.Drawing.Point(646, 72);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(60, 24);
            this.labelScoreText.TabIndex = 3;
            this.labelScoreText.Text = "Score";
            this.labelScoreText.Visible = false;
            // 
            // labelName1
            // 
            this.labelName1.BackColor = System.Drawing.Color.Transparent;
            this.labelName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelName1.Location = new System.Drawing.Point(509, 126);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(133, 24);
            this.labelName1.TabIndex = 4;
            this.labelName1.Text = "P1";
            this.labelName1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelName1.Visible = false;
            // 
            // labelName2
            // 
            this.labelName2.BackColor = System.Drawing.Color.Transparent;
            this.labelName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName2.ForeColor = System.Drawing.Color.Coral;
            this.labelName2.Location = new System.Drawing.Point(509, 171);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(133, 24);
            this.labelName2.TabIndex = 5;
            this.labelName2.Text = "P2";
            this.labelName2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelName2.Visible = false;
            // 
            // buttonColor1
            // 
            this.buttonColor1.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonColor1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonColor1.FlatAppearance.BorderSize = 3;
            this.buttonColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor1.Location = new System.Drawing.Point(731, 125);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(30, 28);
            this.buttonColor1.TabIndex = 6;
            this.buttonColor1.UseVisualStyleBackColor = false;
            this.buttonColor1.Visible = false;
            this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.BackColor = System.Drawing.Color.Coral;
            this.buttonColor2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonColor2.FlatAppearance.BorderSize = 3;
            this.buttonColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor2.Location = new System.Drawing.Point(731, 171);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(30, 27);
            this.buttonColor2.TabIndex = 7;
            this.buttonColor2.UseVisualStyleBackColor = false;
            this.buttonColor2.Visible = false;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.Firebrick;
            this.buttonNewGame.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonNewGame.Location = new System.Drawing.Point(330, 209);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(135, 40);
            this.buttonNewGame.TabIndex = 8;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.Firebrick;
            this.buttonOptions.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOptions.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonOptions.Location = new System.Drawing.Point(330, 272);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(135, 38);
            this.buttonOptions.TabIndex = 9;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // labelColourText
            // 
            this.labelColourText.AutoSize = true;
            this.labelColourText.BackColor = System.Drawing.Color.Transparent;
            this.labelColourText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColourText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelColourText.Location = new System.Drawing.Point(712, 72);
            this.labelColourText.Name = "labelColourText";
            this.labelColourText.Size = new System.Drawing.Size(55, 24);
            this.labelColourText.TabIndex = 12;
            this.labelColourText.Text = "Color";
            this.labelColourText.Visible = false;
            // 
            // labelExtraColour
            // 
            this.labelExtraColour.BackColor = System.Drawing.Color.Transparent;
            this.labelExtraColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtraColour.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelExtraColour.Location = new System.Drawing.Point(713, 198);
            this.labelExtraColour.Name = "labelExtraColour";
            this.labelExtraColour.Size = new System.Drawing.Size(65, 37);
            this.labelExtraColour.TabIndex = 13;
            this.labelExtraColour.Text = "click to change";
            this.labelExtraColour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelExtraColour.Visible = false;
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.BackColor = System.Drawing.Color.Transparent;
            this.labelScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelScore1.Location = new System.Drawing.Point(666, 125);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(20, 24);
            this.labelScore1.TabIndex = 14;
            this.labelScore1.Text = "0";
            this.labelScore1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelScore1.Visible = false;
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.BackColor = System.Drawing.Color.Transparent;
            this.labelScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore2.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelScore2.Location = new System.Drawing.Point(666, 171);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(20, 24);
            this.labelScore2.TabIndex = 15;
            this.labelScore2.Text = "0";
            this.labelScore2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelScore2.Visible = false;
            // 
            // buttonDotsColor
            // 
            this.buttonDotsColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDotsColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDotsColor.FlatAppearance.BorderSize = 3;
            this.buttonDotsColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDotsColor.Location = new System.Drawing.Point(731, 472);
            this.buttonDotsColor.Name = "buttonDotsColor";
            this.buttonDotsColor.Size = new System.Drawing.Size(30, 31);
            this.buttonDotsColor.TabIndex = 16;
            this.buttonDotsColor.UseVisualStyleBackColor = false;
            this.buttonDotsColor.Visible = false;
            this.buttonDotsColor.Click += new System.EventHandler(this.buttonDotsColor_Click);
            // 
            // labelDotsColor
            // 
            this.labelDotsColor.BackColor = System.Drawing.Color.Transparent;
            this.labelDotsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDotsColor.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelDotsColor.Location = new System.Drawing.Point(603, 472);
            this.labelDotsColor.Name = "labelDotsColor";
            this.labelDotsColor.Size = new System.Drawing.Size(123, 31);
            this.labelDotsColor.TabIndex = 17;
            this.labelDotsColor.Text = "Dots color:";
            this.labelDotsColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDotsColor.Visible = false;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.Firebrick;
            this.buttonContinue.Enabled = false;
            this.buttonContinue.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonContinue.Location = new System.Drawing.Point(330, 147);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(135, 40);
            this.buttonContinue.TabIndex = 18;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelExtraColour2
            // 
            this.labelExtraColour2.BackColor = System.Drawing.Color.Transparent;
            this.labelExtraColour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtraColour2.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelExtraColour2.Location = new System.Drawing.Point(713, 503);
            this.labelExtraColour2.Name = "labelExtraColour2";
            this.labelExtraColour2.Size = new System.Drawing.Size(65, 37);
            this.labelExtraColour2.TabIndex = 20;
            this.labelExtraColour2.Text = "click to change";
            this.labelExtraColour2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelExtraColour2.Visible = false;
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.Firebrick;
            this.buttonBackToMenu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToMenu.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonBackToMenu.Location = new System.Drawing.Point(45, 502);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(145, 37);
            this.buttonBackToMenu.TabIndex = 21;
            this.buttonBackToMenu.Text = "Back To Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Visible = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRestart.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonRestart.Location = new System.Drawing.Point(211, 503);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(145, 36);
            this.buttonRestart.TabIndex = 22;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.BackColor = System.Drawing.Color.Firebrick;
            this.buttonEndGame.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndGame.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonEndGame.Location = new System.Drawing.Point(377, 503);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(145, 36);
            this.buttonEndGame.TabIndex = 23;
            this.buttonEndGame.Text = "End Game";
            this.buttonEndGame.UseVisualStyleBackColor = false;
            this.buttonEndGame.Visible = false;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // labelGamesWonCaption
            // 
            this.labelGamesWonCaption.AutoSize = true;
            this.labelGamesWonCaption.BackColor = System.Drawing.Color.Transparent;
            this.labelGamesWonCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamesWonCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGamesWonCaption.Location = new System.Drawing.Point(489, 347);
            this.labelGamesWonCaption.Name = "labelGamesWonCaption";
            this.labelGamesWonCaption.Size = new System.Drawing.Size(116, 24);
            this.labelGamesWonCaption.TabIndex = 24;
            this.labelGamesWonCaption.Text = "Games won:";
            this.labelGamesWonCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGamesWonCaption.Visible = false;
            // 
            // labelTotalScoreCaption
            // 
            this.labelTotalScoreCaption.AutoSize = true;
            this.labelTotalScoreCaption.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalScoreCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalScoreCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTotalScoreCaption.Location = new System.Drawing.Point(497, 310);
            this.labelTotalScoreCaption.Name = "labelTotalScoreCaption";
            this.labelTotalScoreCaption.Size = new System.Drawing.Size(108, 24);
            this.labelTotalScoreCaption.TabIndex = 25;
            this.labelTotalScoreCaption.Text = "Total score:";
            this.labelTotalScoreCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalScoreCaption.Visible = false;
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTotalScore.Location = new System.Drawing.Point(610, 310);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(70, 24);
            this.labelTotalScore.TabIndex = 26;
            this.labelTotalScore.Text = "0 : 0";
            this.labelTotalScore.Visible = false;
            // 
            // labelGamesWon
            // 
            this.labelGamesWon.BackColor = System.Drawing.Color.Transparent;
            this.labelGamesWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamesWon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGamesWon.Location = new System.Drawing.Point(610, 347);
            this.labelGamesWon.Name = "labelGamesWon";
            this.labelGamesWon.Size = new System.Drawing.Size(70, 24);
            this.labelGamesWon.TabIndex = 27;
            this.labelGamesWon.Text = "0 : 0";
            this.labelGamesWon.Visible = false;
            // 
            // labelGameNum
            // 
            this.labelGameNum.AutoSize = true;
            this.labelGameNum.BackColor = System.Drawing.Color.Transparent;
            this.labelGameNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelGameNum.Location = new System.Drawing.Point(81, 22);
            this.labelGameNum.Name = "labelGameNum";
            this.labelGameNum.Size = new System.Drawing.Size(109, 26);
            this.labelGameNum.TabIndex = 28;
            this.labelGameNum.Text = "Game #1";
            this.labelGameNum.Visible = false;
            // 
            // labelMoveCaption
            // 
            this.labelMoveCaption.AutoSize = true;
            this.labelMoveCaption.BackColor = System.Drawing.Color.Transparent;
            this.labelMoveCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoveCaption.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelMoveCaption.Location = new System.Drawing.Point(339, 24);
            this.labelMoveCaption.Name = "labelMoveCaption";
            this.labelMoveCaption.Size = new System.Drawing.Size(153, 24);
            this.labelMoveCaption.TabIndex = 29;
            this.labelMoveCaption.Text = "Move of player:";
            this.labelMoveCaption.Visible = false;
            // 
            // labelGamesToWin
            // 
            this.labelGamesToWin.BackColor = System.Drawing.Color.Transparent;
            this.labelGamesToWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamesToWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGamesToWin.Location = new System.Drawing.Point(754, 347);
            this.labelGamesToWin.Name = "labelGamesToWin";
            this.labelGamesToWin.Size = new System.Drawing.Size(44, 24);
            this.labelGamesToWin.TabIndex = 31;
            this.labelGamesToWin.Text = "1";
            this.labelGamesToWin.Visible = false;
            // 
            // labelNeed
            // 
            this.labelNeed.AutoSize = true;
            this.labelNeed.BackColor = System.Drawing.Color.Transparent;
            this.labelNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNeed.Location = new System.Drawing.Point(686, 347);
            this.labelNeed.Name = "labelNeed";
            this.labelNeed.Size = new System.Drawing.Size(62, 24);
            this.labelNeed.TabIndex = 30;
            this.labelNeed.Text = "Need:";
            this.labelNeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNeed.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 562);
            this.Controls.Add(this.labelGamesToWin);
            this.Controls.Add(this.labelNeed);
            this.Controls.Add(this.labelMoveCaption);
            this.Controls.Add(this.labelGameNum);
            this.Controls.Add(this.labelGamesWon);
            this.Controls.Add(this.labelTotalScore);
            this.Controls.Add(this.labelTotalScoreCaption);
            this.Controls.Add(this.labelGamesWonCaption);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.labelExtraColour2);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelDotsColor);
            this.Controls.Add(this.buttonDotsColor);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.labelExtraColour);
            this.Controls.Add(this.labelColourText);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonColor2);
            this.Controls.Add(this.buttonColor1);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.labelScoreText);
            this.Controls.Add(this.labelMoveID);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMoveID;
        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor1;
        private System.Windows.Forms.Button buttonColor2;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Label labelColourText;
        private System.Windows.Forms.Label labelExtraColour;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Button buttonDotsColor;
        private System.Windows.Forms.Label labelDotsColor;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelExtraColour2;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Label labelGamesWonCaption;
        private System.Windows.Forms.Label labelTotalScoreCaption;
        private System.Windows.Forms.Label labelTotalScore;
        private System.Windows.Forms.Label labelGamesWon;
        private System.Windows.Forms.Label labelGameNum;
        private System.Windows.Forms.Label labelMoveCaption;
        private System.Windows.Forms.Label labelGamesToWin;
        private System.Windows.Forms.Label labelNeed;
    }
}

