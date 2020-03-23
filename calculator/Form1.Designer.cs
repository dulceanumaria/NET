namespace WindowsFormsApp2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnSlash = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnStar = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 33);
            this.textBox1.TabIndex = 0;
            // 
            // BtnNine
            // 
            this.BtnNine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNine.Location = new System.Drawing.Point(297, 3);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(141, 81);
            this.BtnNine.TabIndex = 0;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = false;
            this.BtnNine.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnSlash
            // 
            this.BtnSlash.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSlash.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSlash.Location = new System.Drawing.Point(444, 3);
            this.BtnSlash.Name = "BtnSlash";
            this.BtnSlash.Size = new System.Drawing.Size(142, 81);
            this.BtnSlash.TabIndex = 15;
            this.BtnSlash.Text = "/";
            this.BtnSlash.UseVisualStyleBackColor = false;
            this.BtnSlash.Click += new System.EventHandler(this.Operator_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(456, 9);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(142, 72);
            this.C.TabIndex = 3;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(444, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 83);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Operator_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThree.Location = new System.Drawing.Point(297, 177);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(141, 81);
            this.BtnThree.TabIndex = 10;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = false;
            this.BtnThree.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDot.Location = new System.Drawing.Point(3, 264);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(141, 83);
            this.BtnDot.TabIndex = 12;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZero.Location = new System.Drawing.Point(150, 264);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(141, 83);
            this.BtnZero.TabIndex = 13;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = false;
            this.BtnZero.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEqual.Location = new System.Drawing.Point(297, 264);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(141, 83);
            this.BtnEqual.TabIndex = 14;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.button_Clickeq);
            // 
            // BtnStar
            // 
            this.BtnStar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnStar.Location = new System.Drawing.Point(444, 177);
            this.BtnStar.Name = "BtnStar";
            this.BtnStar.Size = new System.Drawing.Size(142, 81);
            this.BtnStar.TabIndex = 3;
            this.BtnStar.Text = "*";
            this.BtnStar.UseVisualStyleBackColor = false;
            this.BtnStar.Click += new System.EventHandler(this.Operator_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMinus.Location = new System.Drawing.Point(444, 90);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(142, 81);
            this.BtnMinus.TabIndex = 7;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeven.Location = new System.Drawing.Point(3, 3);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(141, 81);
            this.BtnSeven.TabIndex = 1;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = false;
            this.BtnSeven.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEight.Location = new System.Drawing.Point(150, 3);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(141, 81);
            this.BtnEight.TabIndex = 2;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = false;
            this.BtnEight.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFour.Location = new System.Drawing.Point(3, 90);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(141, 81);
            this.BtnFour.TabIndex = 4;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = false;
            this.BtnFour.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFive.Location = new System.Drawing.Point(150, 90);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(141, 81);
            this.BtnFive.TabIndex = 5;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = false;
            this.BtnFive.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSix.Location = new System.Drawing.Point(297, 90);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(141, 81);
            this.BtnSix.TabIndex = 6;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = false;
            this.BtnSix.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOne.Location = new System.Drawing.Point(3, 177);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(141, 81);
            this.BtnOne.TabIndex = 8;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTwo.Location = new System.Drawing.Point(150, 177);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(141, 81);
            this.BtnTwo.TabIndex = 9;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = false;
            this.BtnTwo.Click += new System.EventHandler(this.Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnSeven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnStar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEqual, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnDot, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnSlash, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEight, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 99);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnSlash;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnStar;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}

