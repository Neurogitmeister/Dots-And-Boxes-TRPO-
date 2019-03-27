namespace Dots_And_Boxes__TRPO_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelColCount = new System.Windows.Forms.Label();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.trackBarRows = new System.Windows.Forms.TrackBar();
            this.trackBarCol = new System.Windows.Forms.TrackBar();
            this.buttonOptCancel = new System.Windows.Forms.Button();
            this.buttonOptApply = new System.Windows.Forms.Button();
            this.labelPlayerChose = new System.Windows.Forms.Label();
            this.radioPlayer2 = new System.Windows.Forms.RadioButton();
            this.radioPlayer1 = new System.Windows.Forms.RadioButton();
            this.trackBarDotSize = new System.Windows.Forms.TrackBar();
            this.labelDotSizeVal = new System.Windows.Forms.Label();
            this.labelGameplay = new System.Windows.Forms.Label();
            this.labelGraphics = new System.Windows.Forms.Label();
            this.labelDotSizeCaption = new System.Windows.Forms.Label();
            this.labelDotsColor = new System.Windows.Forms.Label();
            this.buttonDotsColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelNames = new System.Windows.Forms.Label();
            this.player1NameBox = new System.Windows.Forms.TextBox();
            this.player2NameBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarGames = new System.Windows.Forms.TrackBar();
            this.labelGamesToWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGames)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(113, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "OPTIONS";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRows.Location = new System.Drawing.Point(141, 135);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(42, 17);
            this.labelRows.TabIndex = 18;
            this.labelRows.Text = "Rows";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumns.Location = new System.Drawing.Point(132, 84);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(62, 17);
            this.labelColumns.TabIndex = 17;
            this.labelColumns.Text = "Columns";
            // 
            // labelColCount
            // 
            this.labelColCount.AutoSize = true;
            this.labelColCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColCount.Location = new System.Drawing.Point(274, 104);
            this.labelColCount.Name = "labelColCount";
            this.labelColCount.Size = new System.Drawing.Size(18, 20);
            this.labelColCount.TabIndex = 16;
            this.labelColCount.Text = "3";
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRowCount.Location = new System.Drawing.Point(274, 155);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(18, 20);
            this.labelRowCount.TabIndex = 15;
            this.labelRowCount.Text = "3";
            // 
            // trackBarRows
            // 
            this.trackBarRows.LargeChange = 1;
            this.trackBarRows.Location = new System.Drawing.Point(47, 155);
            this.trackBarRows.Maximum = 20;
            this.trackBarRows.Minimum = 2;
            this.trackBarRows.Name = "trackBarRows";
            this.trackBarRows.Size = new System.Drawing.Size(222, 45);
            this.trackBarRows.TabIndex = 14;
            this.trackBarRows.Value = 3;
            this.trackBarRows.ValueChanged += new System.EventHandler(this.trackBarRows_ValueChanged);
            // 
            // trackBarCol
            // 
            this.trackBarCol.LargeChange = 1;
            this.trackBarCol.Location = new System.Drawing.Point(47, 104);
            this.trackBarCol.Maximum = 20;
            this.trackBarCol.Minimum = 2;
            this.trackBarCol.Name = "trackBarCol";
            this.trackBarCol.Size = new System.Drawing.Size(220, 45);
            this.trackBarCol.TabIndex = 13;
            this.trackBarCol.Value = 3;
            this.trackBarCol.ValueChanged += new System.EventHandler(this.trackBarCol_ValueChanged);
            // 
            // buttonOptCancel
            // 
            this.buttonOptCancel.Location = new System.Drawing.Point(175, 495);
            this.buttonOptCancel.Name = "buttonOptCancel";
            this.buttonOptCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonOptCancel.TabIndex = 22;
            this.buttonOptCancel.Text = "Cancel";
            this.buttonOptCancel.UseVisualStyleBackColor = true;
            this.buttonOptCancel.Click += new System.EventHandler(this.buttonOptCancel_Click);
            // 
            // buttonOptApply
            // 
            this.buttonOptApply.Location = new System.Drawing.Point(74, 495);
            this.buttonOptApply.Name = "buttonOptApply";
            this.buttonOptApply.Size = new System.Drawing.Size(75, 23);
            this.buttonOptApply.TabIndex = 21;
            this.buttonOptApply.Text = "Apply";
            this.buttonOptApply.UseVisualStyleBackColor = true;
            this.buttonOptApply.Click += new System.EventHandler(this.buttonOptApply_Click);
            // 
            // labelPlayerChose
            // 
            this.labelPlayerChose.AutoSize = true;
            this.labelPlayerChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerChose.Location = new System.Drawing.Point(77, 266);
            this.labelPlayerChose.Name = "labelPlayerChose";
            this.labelPlayerChose.Size = new System.Drawing.Size(77, 17);
            this.labelPlayerChose.TabIndex = 25;
            this.labelPlayerChose.Text = "First move:";
            // 
            // radioPlayer2
            // 
            this.radioPlayer2.AutoSize = true;
            this.radioPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioPlayer2.Location = new System.Drawing.Point(172, 291);
            this.radioPlayer2.Name = "radioPlayer2";
            this.radioPlayer2.Size = new System.Drawing.Size(78, 21);
            this.radioPlayer2.TabIndex = 24;
            this.radioPlayer2.TabStop = true;
            this.radioPlayer2.Text = "Player 2";
            this.radioPlayer2.UseVisualStyleBackColor = true;
            // 
            // radioPlayer1
            // 
            this.radioPlayer1.AutoSize = true;
            this.radioPlayer1.Checked = true;
            this.radioPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioPlayer1.Location = new System.Drawing.Point(172, 268);
            this.radioPlayer1.Name = "radioPlayer1";
            this.radioPlayer1.Size = new System.Drawing.Size(78, 21);
            this.radioPlayer1.TabIndex = 23;
            this.radioPlayer1.TabStop = true;
            this.radioPlayer1.Text = "Player 1";
            this.radioPlayer1.UseVisualStyleBackColor = true;
            // 
            // trackBarDotSize
            // 
            this.trackBarDotSize.LargeChange = 4;
            this.trackBarDotSize.Location = new System.Drawing.Point(34, 436);
            this.trackBarDotSize.Maximum = 13;
            this.trackBarDotSize.Minimum = 1;
            this.trackBarDotSize.Name = "trackBarDotSize";
            this.trackBarDotSize.Size = new System.Drawing.Size(97, 45);
            this.trackBarDotSize.SmallChange = 2;
            this.trackBarDotSize.TabIndex = 26;
            this.trackBarDotSize.TickFrequency = 2;
            this.trackBarDotSize.Value = 3;
            this.trackBarDotSize.ValueChanged += new System.EventHandler(this.trackBarDotSize_ValueChanged);
            // 
            // labelDotSizeVal
            // 
            this.labelDotSizeVal.AutoSize = true;
            this.labelDotSizeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDotSizeVal.Location = new System.Drawing.Point(139, 436);
            this.labelDotSizeVal.Name = "labelDotSizeVal";
            this.labelDotSizeVal.Size = new System.Drawing.Size(18, 20);
            this.labelDotSizeVal.TabIndex = 27;
            this.labelDotSizeVal.Text = "3";
            // 
            // labelGameplay
            // 
            this.labelGameplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameplay.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelGameplay.Location = new System.Drawing.Point(28, 48);
            this.labelGameplay.Name = "labelGameplay";
            this.labelGameplay.Size = new System.Drawing.Size(270, 23);
            this.labelGameplay.TabIndex = 28;
            this.labelGameplay.Text = "                   Gameplay                        ";
            this.labelGameplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGraphics
            // 
            this.labelGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraphics.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelGraphics.Location = new System.Drawing.Point(31, 381);
            this.labelGraphics.Name = "labelGraphics";
            this.labelGraphics.Size = new System.Drawing.Size(267, 23);
            this.labelGraphics.TabIndex = 29;
            this.labelGraphics.Text = "                   Graphics                          ";
            // 
            // labelDotSizeCaption
            // 
            this.labelDotSizeCaption.AutoSize = true;
            this.labelDotSizeCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDotSizeCaption.Location = new System.Drawing.Point(30, 416);
            this.labelDotSizeCaption.Name = "labelDotSizeCaption";
            this.labelDotSizeCaption.Size = new System.Drawing.Size(127, 17);
            this.labelDotSizeCaption.TabIndex = 30;
            this.labelDotSizeCaption.Text = "Dots and lines size";
            // 
            // labelDotsColor
            // 
            this.labelDotsColor.AutoSize = true;
            this.labelDotsColor.BackColor = System.Drawing.Color.Transparent;
            this.labelDotsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDotsColor.ForeColor = System.Drawing.Color.Black;
            this.labelDotsColor.Location = new System.Drawing.Point(201, 417);
            this.labelDotsColor.Name = "labelDotsColor";
            this.labelDotsColor.Size = new System.Drawing.Size(78, 17);
            this.labelDotsColor.TabIndex = 32;
            this.labelDotsColor.Text = "Dots Color:";
            // 
            // buttonDotsColor
            // 
            this.buttonDotsColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDotsColor.Location = new System.Drawing.Point(220, 437);
            this.buttonDotsColor.Name = "buttonDotsColor";
            this.buttonDotsColor.Size = new System.Drawing.Size(30, 31);
            this.buttonDotsColor.TabIndex = 31;
            this.buttonDotsColor.UseVisualStyleBackColor = false;
            this.buttonDotsColor.Click += new System.EventHandler(this.buttonDotsColor_Click);
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNames.Location = new System.Drawing.Point(46, 193);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(108, 17);
            this.labelNames.TabIndex = 33;
            this.labelNames.Text = "Player\'s names:";
            // 
            // player1NameBox
            // 
            this.player1NameBox.CausesValidation = false;
            this.player1NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1NameBox.Location = new System.Drawing.Point(171, 193);
            this.player1NameBox.Name = "player1NameBox";
            this.player1NameBox.Size = new System.Drawing.Size(125, 23);
            this.player1NameBox.TabIndex = 34;
            this.player1NameBox.Text = "Player 1";
            this.player1NameBox.TextChanged += new System.EventHandler(this.player1NameBox_TextChanged);
            // 
            // player2NameBox
            // 
            this.player2NameBox.CausesValidation = false;
            this.player2NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2NameBox.Location = new System.Drawing.Point(171, 222);
            this.player2NameBox.Name = "player2NameBox";
            this.player2NameBox.Size = new System.Drawing.Size(125, 23);
            this.player2NameBox.TabIndex = 35;
            this.player2NameBox.Text = "Player 2";
            this.player2NameBox.TextChanged += new System.EventHandler(this.player2NameBox_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Games to win:";
            // 
            // trackBarGames
            // 
            this.trackBarGames.LargeChange = 4;
            this.trackBarGames.Location = new System.Drawing.Point(172, 330);
            this.trackBarGames.Maximum = 15;
            this.trackBarGames.Minimum = 1;
            this.trackBarGames.Name = "trackBarGames";
            this.trackBarGames.Size = new System.Drawing.Size(97, 45);
            this.trackBarGames.SmallChange = 2;
            this.trackBarGames.TabIndex = 37;
            this.trackBarGames.TickFrequency = 2;
            this.trackBarGames.Value = 1;
            this.trackBarGames.ValueChanged += new System.EventHandler(this.trackBarGames_ValueChanged);
            // 
            // labelGamesToWin
            // 
            this.labelGamesToWin.AutoSize = true;
            this.labelGamesToWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamesToWin.Location = new System.Drawing.Point(275, 330);
            this.labelGamesToWin.Name = "labelGamesToWin";
            this.labelGamesToWin.Size = new System.Drawing.Size(18, 20);
            this.labelGamesToWin.TabIndex = 38;
            this.labelGamesToWin.Text = "1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(326, 540);
            this.Controls.Add(this.labelGamesToWin);
            this.Controls.Add(this.trackBarGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2NameBox);
            this.Controls.Add(this.player1NameBox);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.labelDotsColor);
            this.Controls.Add(this.buttonDotsColor);
            this.Controls.Add(this.labelDotSizeCaption);
            this.Controls.Add(this.labelGraphics);
            this.Controls.Add(this.labelGameplay);
            this.Controls.Add(this.labelDotSizeVal);
            this.Controls.Add(this.trackBarDotSize);
            this.Controls.Add(this.labelPlayerChose);
            this.Controls.Add(this.radioPlayer2);
            this.Controls.Add(this.radioPlayer1);
            this.Controls.Add(this.buttonOptCancel);
            this.Controls.Add(this.buttonOptApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelColCount);
            this.Controls.Add(this.labelRowCount);
            this.Controls.Add(this.trackBarRows);
            this.Controls.Add(this.trackBarCol);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDotSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelColCount;
        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.TrackBar trackBarRows;
        private System.Windows.Forms.TrackBar trackBarCol;
        private System.Windows.Forms.Button buttonOptCancel;
        private System.Windows.Forms.Button buttonOptApply;
        private System.Windows.Forms.Label labelPlayerChose;
        private System.Windows.Forms.RadioButton radioPlayer2;
        private System.Windows.Forms.RadioButton radioPlayer1;
        private System.Windows.Forms.TrackBar trackBarDotSize;
        private System.Windows.Forms.Label labelDotSizeVal;
        private System.Windows.Forms.Label labelGameplay;
        private System.Windows.Forms.Label labelGraphics;
        private System.Windows.Forms.Label labelDotSizeCaption;
        private System.Windows.Forms.Label labelDotsColor;
        private System.Windows.Forms.Button buttonDotsColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.TextBox player1NameBox;
        private System.Windows.Forms.TextBox player2NameBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarGames;
        private System.Windows.Forms.Label labelGamesToWin;
    }
}