namespace Dots_And_Boxes__TRPO_
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
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelColourText = new System.Windows.Forms.Label();
            this.labelExtraColour = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.buttonDotsColor = new System.Windows.Forms.Button();
            this.labelDotsColor = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.labelExtraColour2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 22);
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
            this.labelMoveID.Location = new System.Drawing.Point(627, 203);
            this.labelMoveID.Name = "labelMoveID";
            this.labelMoveID.Size = new System.Drawing.Size(175, 24);
            this.labelMoveID.TabIndex = 2;
            this.labelMoveID.Text = "Move of player №_";
            this.labelMoveID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMoveID.Visible = false;
            // 
            // labelScoreText
            // 
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.BackColor = System.Drawing.Color.Transparent;
            this.labelScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelScoreText.Location = new System.Drawing.Point(670, 27);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(60, 24);
            this.labelScoreText.TabIndex = 3;
            this.labelScoreText.Text = "Score";
            this.labelScoreText.Visible = false;
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.BackColor = System.Drawing.Color.Transparent;
            this.labelName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelName1.Location = new System.Drawing.Point(634, 81);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(32, 24);
            this.labelName1.TabIndex = 4;
            this.labelName1.Text = "P1";
            this.labelName1.Visible = false;
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.BackColor = System.Drawing.Color.Transparent;
            this.labelName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName2.ForeColor = System.Drawing.Color.Coral;
            this.labelName2.Location = new System.Drawing.Point(634, 126);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(32, 24);
            this.labelName2.TabIndex = 5;
            this.labelName2.Text = "P2";
            this.labelName2.Visible = false;
            // 
            // buttonColor1
            // 
            this.buttonColor1.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonColor1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonColor1.FlatAppearance.BorderSize = 3;
            this.buttonColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor1.Location = new System.Drawing.Point(755, 80);
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
            this.buttonColor2.Location = new System.Drawing.Point(755, 126);
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
            this.buttonNewGame.Location = new System.Drawing.Point(347, 126);
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
            this.buttonOptions.Location = new System.Drawing.Point(347, 189);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(135, 38);
            this.buttonOptions.TabIndex = 9;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.Firebrick;
            this.buttonBackToMenu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToMenu.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonBackToMenu.Location = new System.Drawing.Point(22, 59);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(145, 37);
            this.buttonBackToMenu.TabIndex = 10;
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
            this.buttonRestart.Location = new System.Drawing.Point(22, 114);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(145, 36);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelColourText
            // 
            this.labelColourText.AutoSize = true;
            this.labelColourText.BackColor = System.Drawing.Color.Transparent;
            this.labelColourText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColourText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelColourText.Location = new System.Drawing.Point(736, 27);
            this.labelColourText.Name = "labelColourText";
            this.labelColourText.Size = new System.Drawing.Size(66, 24);
            this.labelColourText.TabIndex = 12;
            this.labelColourText.Text = "Colour";
            this.labelColourText.Visible = false;
            // 
            // labelExtraColour
            // 
            this.labelExtraColour.BackColor = System.Drawing.Color.Transparent;
            this.labelExtraColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtraColour.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelExtraColour.Location = new System.Drawing.Point(737, 153);
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
            this.labelScore1.Location = new System.Drawing.Point(690, 80);
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
            this.labelScore2.Location = new System.Drawing.Point(690, 126);
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
            this.buttonDotsColor.Location = new System.Drawing.Point(755, 326);
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
            this.labelDotsColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDotsColor.Location = new System.Drawing.Point(627, 326);
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
            this.buttonContinue.Location = new System.Drawing.Point(347, 64);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(135, 40);
            this.buttonContinue.TabIndex = 18;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.BackColor = System.Drawing.Color.Firebrick;
            this.buttonEndGame.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndGame.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonEndGame.Location = new System.Drawing.Point(22, 167);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(145, 36);
            this.buttonEndGame.TabIndex = 19;
            this.buttonEndGame.Text = "End Game";
            this.buttonEndGame.UseVisualStyleBackColor = false;
            this.buttonEndGame.Visible = false;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // labelExtraColour2
            // 
            this.labelExtraColour2.BackColor = System.Drawing.Color.Transparent;
            this.labelExtraColour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtraColour2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelExtraColour2.Location = new System.Drawing.Point(737, 357);
            this.labelExtraColour2.Name = "labelExtraColour2";
            this.labelExtraColour2.Size = new System.Drawing.Size(65, 37);
            this.labelExtraColour2.TabIndex = 20;
            this.labelExtraColour2.Text = "click to change";
            this.labelExtraColour2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelExtraColour2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExtraColour2);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelDotsColor);
            this.Controls.Add(this.buttonDotsColor);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.labelExtraColour);
            this.Controls.Add(this.labelColourText);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonBackToMenu);
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
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelColourText;
        private System.Windows.Forms.Label labelExtraColour;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Button buttonDotsColor;
        private System.Windows.Forms.Label labelDotsColor;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Label labelExtraColour2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

