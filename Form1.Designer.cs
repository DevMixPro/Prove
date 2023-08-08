namespace calculadora_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LCDtxt = new TextBox();
            btnraiz = new Button();
            btnpor = new Button();
            btncl = new Button();
            btndel = new Button();
            btndiv = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnmul = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnres = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnsum = new Button();
            btndot = new Button();
            btn0 = new Button();
            btnpot = new Button();
            btnigual = new Button();
            SuspendLayout();
            // 
            // LCDtxt
            // 
            LCDtxt.BackColor = Color.FromArgb(0, 192, 0);
            LCDtxt.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            LCDtxt.Location = new Point(10, 10);
            LCDtxt.MaxLength = 10;
            LCDtxt.Name = "LCDtxt";
            LCDtxt.ReadOnly = true;
            LCDtxt.RightToLeft = RightToLeft.Yes;
            LCDtxt.Size = new Size(260, 54);
            LCDtxt.TabIndex = 0;
            LCDtxt.Text = "0";
            // 
            // btnraiz
            // 
            btnraiz.BackColor = Color.FromArgb(0, 192, 0);
            btnraiz.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnraiz.ForeColor = Color.Red;
            btnraiz.Location = new Point(12, 357);
            btnraiz.Name = "btnraiz";
            btnraiz.Size = new Size(60, 60);
            btnraiz.TabIndex = 1;
            btnraiz.Tag = "√";
            btnraiz.Text = "√";
            btnraiz.UseVisualStyleBackColor = false;
            // 
            // btnpor
            // 
            btnpor.BackColor = Color.FromArgb(0, 192, 0);
            btnpor.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnpor.ForeColor = Color.Red;
            btnpor.Location = new Point(78, 93);
            btnpor.Name = "btnpor";
            btnpor.Size = new Size(60, 60);
            btnpor.TabIndex = 2;
            btnpor.Tag = "%";
            btnpor.Text = "%";
            btnpor.UseVisualStyleBackColor = false;
            btnpor.Click += caracter;
            // 
            // btncl
            // 
            btncl.BackColor = Color.FromArgb(0, 192, 0);
            btncl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncl.ForeColor = Color.Blue;
            btncl.Location = new Point(144, 93);
            btncl.Name = "btncl";
            btncl.Size = new Size(60, 60);
            btncl.TabIndex = 3;
            btncl.Text = "Cl";
            btncl.UseVisualStyleBackColor = false;
            btncl.Click += btncl_Click;
            // 
            // btndel
            // 
            btndel.BackColor = Color.FromArgb(0, 192, 0);
            btndel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndel.ForeColor = Color.Blue;
            btndel.Location = new Point(210, 93);
            btndel.Name = "btndel";
            btndel.Size = new Size(60, 60);
            btndel.TabIndex = 4;
            btndel.Text = "Del";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = Color.FromArgb(0, 192, 0);
            btndiv.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndiv.ForeColor = Color.Red;
            btndiv.Location = new Point(210, 159);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(60, 60);
            btndiv.TabIndex = 8;
            btndiv.Tag = "/";
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += caracter;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(0, 192, 0);
            btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(144, 159);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 7;
            btn9.Tag = "cambioLCD";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += cambioLCD;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(0, 192, 0);
            btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(78, 159);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 6;
            btn8.Tag = "cambioLCD";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += cambioLCD;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(0, 192, 0);
            btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 159);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 5;
            btn7.Tag = "cambioLCD";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += cambioLCD;
            // 
            // btnmul
            // 
            btnmul.BackColor = Color.FromArgb(0, 192, 0);
            btnmul.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnmul.ForeColor = Color.Red;
            btnmul.Location = new Point(210, 225);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(60, 60);
            btnmul.TabIndex = 12;
            btnmul.Tag = "*";
            btnmul.Text = "*";
            btnmul.UseVisualStyleBackColor = false;
            btnmul.Click += caracter;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(0, 192, 0);
            btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(144, 225);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 11;
            btn6.Tag = "cambioLCD";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += cambioLCD;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(0, 192, 0);
            btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(78, 225);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 10;
            btn5.Tag = "cambioLCD";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += cambioLCD;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(0, 192, 0);
            btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 225);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 9;
            btn4.Tag = "cambioLCD";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += cambioLCD;
            // 
            // btnres
            // 
            btnres.BackColor = Color.FromArgb(0, 192, 0);
            btnres.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnres.ForeColor = Color.Red;
            btnres.Location = new Point(210, 291);
            btnres.Name = "btnres";
            btnres.Size = new Size(60, 60);
            btnres.TabIndex = 16;
            btnres.Tag = "-";
            btnres.Text = "-";
            btnres.UseVisualStyleBackColor = false;
            btnres.Click += caracter;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(0, 192, 0);
            btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(144, 291);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 15;
            btn3.Tag = "cambioLCD";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += cambioLCD;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(0, 192, 0);
            btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(78, 291);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 14;
            btn2.Tag = "cambioLCD";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += cambioLCD;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(0, 192, 0);
            btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 291);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 13;
            btn1.Tag = "cambioLCD";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += cambioLCD;
            // 
            // btnsum
            // 
            btnsum.BackColor = Color.FromArgb(0, 192, 0);
            btnsum.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsum.ForeColor = Color.Red;
            btnsum.Location = new Point(210, 357);
            btnsum.Name = "btnsum";
            btnsum.Size = new Size(60, 60);
            btnsum.TabIndex = 20;
            btnsum.Tag = "+";
            btnsum.Text = "+";
            btnsum.UseVisualStyleBackColor = false;
            btnsum.Click += caracter;
            // 
            // btndot
            // 
            btndot.BackColor = Color.FromArgb(0, 192, 0);
            btndot.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndot.ForeColor = Color.Red;
            btndot.Location = new Point(144, 357);
            btndot.Name = "btndot";
            btndot.Size = new Size(60, 60);
            btndot.TabIndex = 19;
            btndot.Tag = ".";
            btndot.Text = ".";
            btndot.TextAlign = ContentAlignment.TopCenter;
            btndot.UseVisualStyleBackColor = false;
            btndot.Click += btndot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(0, 192, 0);
            btn0.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(78, 357);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 60);
            btn0.TabIndex = 18;
            btn0.Tag = "cambioLCD";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += cambioLCD;
            // 
            // btnpot
            // 
            btnpot.BackColor = Color.FromArgb(0, 192, 0);
            btnpot.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnpot.ForeColor = Color.Red;
            btnpot.Location = new Point(12, 93);
            btnpot.Name = "btnpot";
            btnpot.Size = new Size(60, 60);
            btnpot.TabIndex = 17;
            btnpot.Tag = "^";
            btnpot.Text = "^";
            btnpot.UseVisualStyleBackColor = false;
            btnpot.Click += caracter;
            // 
            // btnigual
            // 
            btnigual.BackColor = Color.FromArgb(0, 192, 0);
            btnigual.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnigual.ForeColor = Color.Red;
            btnigual.Location = new Point(12, 423);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(258, 60);
            btnigual.TabIndex = 21;
            btnigual.Tag = "=";
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = false;
            btnigual.Click += btnigual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(284, 511);
            Controls.Add(btnigual);
            Controls.Add(btnsum);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btnpot);
            Controls.Add(btnres);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnmul);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btndiv);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btndel);
            Controls.Add(btncl);
            Controls.Add(btnpor);
            Controls.Add(btnraiz);
            Controls.Add(LCDtxt);
            ForeColor = Color.Black;
            MaximumSize = new Size(300, 550);
            MinimumSize = new Size(300, 550);
            Name = "Form1";
            Text = "Best Calc Ever ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LCDtxt;
        private Button btnraiz;
        private Button btnpor;
        private Button btncl;
        private Button btndel;
        private Button btndiv;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnmul;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnres;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnsum;
        private Button btndot;
        private Button btn0;
        private Button btnpot;
        private Button btnigual;
    }
}