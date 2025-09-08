namespace CalculatorC_
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
            number1 = new Button();
            textBox1 = new TextBox();
            number2 = new Button();
            number5 = new Button();
            number4 = new Button();
            number8 = new Button();
            number7 = new Button();
            number0 = new Button();
            btnadd = new Button();
            btnclaer = new Button();
            btnmultiply = new Button();
            btnminus = new Button();
            btnequal = new Button();
            btndivide = new Button();
            number9 = new Button();
            number6 = new Button();
            number3 = new Button();
            btnsqrt = new Button();
            btnonehalf = new Button();
            btnsq = new Button();
            SuspendLayout();
            // 
            // number1
            // 
            number1.BackColor = Color.FromArgb(255, 255, 128);
            number1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number1.Location = new Point(12, 117);
            number1.Name = "number1";
            number1.Size = new Size(146, 39);
            number1.TabIndex = 0;
            number1.Tag = "";
            number1.Text = "1";
            number1.UseVisualStyleBackColor = false;
            number1.Click += number1Btn;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 54);
            textBox1.TabIndex = 6;
            // 
            // number2
            // 
            number2.BackColor = Color.FromArgb(255, 255, 128);
            number2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number2.Location = new Point(164, 117);
            number2.Name = "number2";
            number2.Size = new Size(146, 39);
            number2.TabIndex = 7;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = false;
            number2.Click += number2Btn;
            // 
            // number5
            // 
            number5.BackColor = Color.Yellow;
            number5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number5.Location = new Point(164, 162);
            number5.Name = "number5";
            number5.Size = new Size(146, 39);
            number5.TabIndex = 10;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = false;
            number5.Click += number5Btn;
            // 
            // number4
            // 
            number4.BackColor = Color.Yellow;
            number4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number4.Location = new Point(12, 162);
            number4.Name = "number4";
            number4.Size = new Size(146, 39);
            number4.TabIndex = 9;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = false;
            number4.Click += number4Btn;
            // 
            // number8
            // 
            number8.BackColor = Color.FromArgb(192, 192, 0);
            number8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number8.ForeColor = SystemColors.ControlLightLight;
            number8.Location = new Point(164, 207);
            number8.Name = "number8";
            number8.Size = new Size(146, 39);
            number8.TabIndex = 13;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = false;
            number8.Click += number8Btn;
            // 
            // number7
            // 
            number7.BackColor = Color.FromArgb(192, 192, 0);
            number7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number7.ForeColor = SystemColors.ControlLightLight;
            number7.Location = new Point(12, 207);
            number7.Name = "number7";
            number7.Size = new Size(146, 39);
            number7.TabIndex = 12;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = false;
            number7.Click += number7Btn;
            // 
            // number0
            // 
            number0.BackColor = Color.Olive;
            number0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number0.ForeColor = SystemColors.ControlLightLight;
            number0.Location = new Point(164, 252);
            number0.Name = "number0";
            number0.Size = new Size(146, 39);
            number0.TabIndex = 16;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = false;
            number0.Click += number0Btn;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Olive;
            btnadd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.ForeColor = SystemColors.ControlLightLight;
            btnadd.Location = new Point(12, 252);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(146, 39);
            btnadd.TabIndex = 15;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += AddBtn;
            // 
            // btnclaer
            // 
            btnclaer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnclaer.BackColor = SystemColors.MenuHighlight;
            btnclaer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclaer.Location = new Point(12, 342);
            btnclaer.Name = "btnclaer";
            btnclaer.Size = new Size(439, 39);
            btnclaer.TabIndex = 18;
            btnclaer.Text = "CLEAR";
            btnclaer.UseVisualStyleBackColor = false;
            btnclaer.Click += clearBtn;
            // 
            // btnmultiply
            // 
            btnmultiply.BackColor = Color.FromArgb(64, 64, 0);
            btnmultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmultiply.ForeColor = Color.White;
            btnmultiply.Location = new Point(164, 297);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(146, 39);
            btnmultiply.TabIndex = 20;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = false;
            btnmultiply.Click += multiplyBtn;
            // 
            // btnminus
            // 
            btnminus.BackColor = Color.FromArgb(64, 64, 0);
            btnminus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnminus.ForeColor = Color.White;
            btnminus.Location = new Point(12, 297);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(146, 39);
            btnminus.TabIndex = 19;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += minusBtn;
            // 
            // btnequal
            // 
            btnequal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnequal.BackColor = Color.FromArgb(64, 64, 0);
            btnequal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnequal.ForeColor = Color.White;
            btnequal.Location = new Point(316, 297);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(135, 39);
            btnequal.TabIndex = 21;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = false;
            btnequal.Click += equalBtn;
            // 
            // btndivide
            // 
            btndivide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btndivide.BackColor = Color.Olive;
            btndivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndivide.ForeColor = SystemColors.ControlLightLight;
            btndivide.Location = new Point(316, 252);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(135, 39);
            btndivide.TabIndex = 17;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = false;
            btndivide.Click += DivideBtn;
            // 
            // number9
            // 
            number9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            number9.BackColor = Color.FromArgb(192, 192, 0);
            number9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number9.ForeColor = SystemColors.ControlLightLight;
            number9.Location = new Point(316, 207);
            number9.Name = "number9";
            number9.Size = new Size(135, 39);
            number9.TabIndex = 14;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = false;
            number9.Click += number9Btn;
            // 
            // number6
            // 
            number6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            number6.BackColor = Color.Yellow;
            number6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number6.ForeColor = SystemColors.ControlText;
            number6.Location = new Point(316, 162);
            number6.Name = "number6";
            number6.Size = new Size(135, 39);
            number6.TabIndex = 11;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = false;
            number6.Click += number6Btn;
            // 
            // number3
            // 
            number3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            number3.BackColor = Color.FromArgb(255, 255, 128);
            number3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number3.Location = new Point(316, 117);
            number3.Name = "number3";
            number3.Size = new Size(135, 39);
            number3.TabIndex = 8;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = false;
            number3.Click += number3Btn;
            // 
            // btnsqrt
            // 
            btnsqrt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnsqrt.BackColor = Color.FromArgb(255, 255, 192);
            btnsqrt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsqrt.Location = new Point(316, 72);
            btnsqrt.Name = "btnsqrt";
            btnsqrt.Size = new Size(135, 39);
            btnsqrt.TabIndex = 24;
            btnsqrt.Text = "sqrt";
            btnsqrt.UseVisualStyleBackColor = false;
            btnsqrt.Click += sqrtBtn;
            // 
            // btnonehalf
            // 
            btnonehalf.BackColor = Color.FromArgb(255, 255, 192);
            btnonehalf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnonehalf.Location = new Point(164, 72);
            btnonehalf.Name = "btnonehalf";
            btnonehalf.Size = new Size(146, 39);
            btnonehalf.TabIndex = 23;
            btnonehalf.Text = "1/x";
            btnonehalf.UseVisualStyleBackColor = false;
            btnonehalf.Click += oneHalfBtn;
            // 
            // btnsq
            // 
            btnsq.BackColor = Color.FromArgb(255, 255, 192);
            btnsq.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsq.Location = new Point(12, 72);
            btnsq.Name = "btnsq";
            btnsq.Size = new Size(146, 39);
            btnsq.TabIndex = 22;
            btnsq.Text = "x^2";
            btnsq.UseVisualStyleBackColor = false;
            btnsq.Click += squareBtn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(463, 454);
            Controls.Add(btnsqrt);
            Controls.Add(btnonehalf);
            Controls.Add(btnsq);
            Controls.Add(btnequal);
            Controls.Add(btnmultiply);
            Controls.Add(btnminus);
            Controls.Add(btnclaer);
            Controls.Add(btndivide);
            Controls.Add(number0);
            Controls.Add(btnadd);
            Controls.Add(number9);
            Controls.Add(number8);
            Controls.Add(number7);
            Controls.Add(number6);
            Controls.Add(number5);
            Controls.Add(number4);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(textBox1);
            Controls.Add(number1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Calculator ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button number1;
        private TextBox textBox1;
        private Button number2;
        private Button number5;
        private Button number4;
        private Button number8;
        private Button number7;
        private Button number0;
        private Button btnclaer;
        private Button btnmultiply;
        private Button btnminus;
        private Button btnequal;
        private Button number9;
        private Button number6;
        private Button number3;
        private Button btnsqrt;
        private Button btnonehalf;
        private Button btnsq;
        private Button btnadd;
        private Button addBtn;
        private Button btndivide;
        private Button divideBtn;
    }
}
