namespace WindowsFormsApp2
{
    partial class StringSimbol
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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonRightBracket = new System.Windows.Forms.Button();
            this.buttonLeftBracket = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBagi = new System.Windows.Forms.Button();
            this.buttonKali = new System.Windows.Forms.Button();
            this.buttonKurang = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.White;
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(343, 34);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(218, 44);
            this.textBoxOutput.TabIndex = 41;
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // buttonRightBracket
            // 
            this.buttonRightBracket.BackColor = System.Drawing.Color.Silver;
            this.buttonRightBracket.Location = new System.Drawing.Point(511, 84);
            this.buttonRightBracket.Name = "buttonRightBracket";
            this.buttonRightBracket.Size = new System.Drawing.Size(50, 50);
            this.buttonRightBracket.TabIndex = 40;
            this.buttonRightBracket.Text = ")";
            this.buttonRightBracket.UseVisualStyleBackColor = false;
            // 
            // buttonLeftBracket
            // 
            this.buttonLeftBracket.BackColor = System.Drawing.Color.Silver;
            this.buttonLeftBracket.Location = new System.Drawing.Point(455, 84);
            this.buttonLeftBracket.Name = "buttonLeftBracket";
            this.buttonLeftBracket.Size = new System.Drawing.Size(50, 50);
            this.buttonLeftBracket.TabIndex = 39;
            this.buttonLeftBracket.Text = "(";
            this.buttonLeftBracket.UseVisualStyleBackColor = false;
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClearEntry.Location = new System.Drawing.Point(399, 84);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(50, 50);
            this.buttonClearEntry.TabIndex = 38;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClear.Location = new System.Drawing.Point(343, 84);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonBagi
            // 
            this.buttonBagi.BackColor = System.Drawing.Color.Silver;
            this.buttonBagi.Location = new System.Drawing.Point(511, 308);
            this.buttonBagi.Name = "buttonBagi";
            this.buttonBagi.Size = new System.Drawing.Size(50, 50);
            this.buttonBagi.TabIndex = 36;
            this.buttonBagi.Text = ":";
            this.buttonBagi.UseVisualStyleBackColor = false;
            // 
            // buttonKali
            // 
            this.buttonKali.BackColor = System.Drawing.Color.Silver;
            this.buttonKali.Location = new System.Drawing.Point(511, 252);
            this.buttonKali.Name = "buttonKali";
            this.buttonKali.Size = new System.Drawing.Size(50, 50);
            this.buttonKali.TabIndex = 35;
            this.buttonKali.Text = "X";
            this.buttonKali.UseVisualStyleBackColor = false;
            // 
            // buttonKurang
            // 
            this.buttonKurang.BackColor = System.Drawing.Color.Silver;
            this.buttonKurang.Location = new System.Drawing.Point(511, 196);
            this.buttonKurang.Name = "buttonKurang";
            this.buttonKurang.Size = new System.Drawing.Size(50, 50);
            this.buttonKurang.TabIndex = 34;
            this.buttonKurang.Text = "-";
            this.buttonKurang.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Silver;
            this.buttonTambah.Location = new System.Drawing.Point(511, 140);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(50, 50);
            this.buttonTambah.TabIndex = 33;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = false;
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.Silver;
            this.buttonEquals.Location = new System.Drawing.Point(455, 308);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 50);
            this.buttonEquals.TabIndex = 32;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackColor = System.Drawing.Color.Silver;
            this.buttonDecimal.Location = new System.Drawing.Point(399, 308);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(50, 50);
            this.buttonDecimal.TabIndex = 31;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Gainsboro;
            this.button0.Location = new System.Drawing.Point(343, 308);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 30;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.Location = new System.Drawing.Point(455, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 29;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.Location = new System.Drawing.Point(399, 252);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 28;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Location = new System.Drawing.Point(343, 252);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 27;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(455, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 26;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(399, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 25;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(343, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 24;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(455, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 23;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(399, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(343, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // StringSimbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonRightBracket);
            this.Controls.Add(this.buttonLeftBracket);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBagi);
            this.Controls.Add(this.buttonKali);
            this.Controls.Add(this.buttonKurang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StringSimbol";
            this.Text = "StringSimbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonRightBracket;
        private System.Windows.Forms.Button buttonLeftBracket;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBagi;
        private System.Windows.Forms.Button buttonKali;
        private System.Windows.Forms.Button buttonKurang;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}