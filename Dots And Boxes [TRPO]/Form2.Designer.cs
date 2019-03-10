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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelColCount = new System.Windows.Forms.Label();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.trackBarRows = new System.Windows.Forms.TrackBar();
            this.trackBarCol = new System.Windows.Forms.TrackBar();
            this.buttonOptCancel = new System.Windows.Forms.Button();
            this.buttonOptApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCol)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "OPTIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rows";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Columns";
            // 
            // labelColCount
            // 
            this.labelColCount.AutoSize = true;
            this.labelColCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColCount.Location = new System.Drawing.Point(134, 118);
            this.labelColCount.Name = "labelColCount";
            this.labelColCount.Size = new System.Drawing.Size(18, 20);
            this.labelColCount.TabIndex = 16;
            this.labelColCount.Text = "3";
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRowCount.Location = new System.Drawing.Point(133, 187);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(18, 20);
            this.labelRowCount.TabIndex = 15;
            this.labelRowCount.Text = "3";
            // 
            // trackBarRows
            // 
            this.trackBarRows.LargeChange = 1;
            this.trackBarRows.Location = new System.Drawing.Point(23, 187);
            this.trackBarRows.Minimum = 2;
            this.trackBarRows.Name = "trackBarRows";
            this.trackBarRows.Size = new System.Drawing.Size(104, 45);
            this.trackBarRows.TabIndex = 14;
            this.trackBarRows.Value = 3;
            this.trackBarRows.ValueChanged += new System.EventHandler(this.trackBarRows_ValueChanged);
            // 
            // trackBarCol
            // 
            this.trackBarCol.LargeChange = 1;
            this.trackBarCol.Location = new System.Drawing.Point(23, 118);
            this.trackBarCol.Minimum = 2;
            this.trackBarCol.Name = "trackBarCol";
            this.trackBarCol.Size = new System.Drawing.Size(104, 45);
            this.trackBarCol.TabIndex = 13;
            this.trackBarCol.Value = 3;
            this.trackBarCol.ValueChanged += new System.EventHandler(this.trackBarCol_ValueChanged);
            // 
            // buttonOptCancel
            // 
            this.buttonOptCancel.Location = new System.Drawing.Point(173, 251);
            this.buttonOptCancel.Name = "buttonOptCancel";
            this.buttonOptCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonOptCancel.TabIndex = 22;
            this.buttonOptCancel.Text = "Cancel";
            this.buttonOptCancel.UseVisualStyleBackColor = true;
            this.buttonOptCancel.Click += new System.EventHandler(this.buttonOptCancel_Click);
            // 
            // buttonOptApply
            // 
            this.buttonOptApply.Location = new System.Drawing.Point(72, 251);
            this.buttonOptApply.Name = "buttonOptApply";
            this.buttonOptApply.Size = new System.Drawing.Size(75, 23);
            this.buttonOptApply.TabIndex = 21;
            this.buttonOptApply.Text = "Apply";
            this.buttonOptApply.UseVisualStyleBackColor = true;
            this.buttonOptApply.Click += new System.EventHandler(this.buttonOptApply_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 308);
            this.Controls.Add(this.buttonOptCancel);
            this.Controls.Add(this.buttonOptApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelColCount);
            this.Controls.Add(this.labelRowCount);
            this.Controls.Add(this.trackBarRows);
            this.Controls.Add(this.trackBarCol);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelColCount;
        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.TrackBar trackBarRows;
        private System.Windows.Forms.TrackBar trackBarCol;
        private System.Windows.Forms.Button buttonOptCancel;
        private System.Windows.Forms.Button buttonOptApply;
    }
}