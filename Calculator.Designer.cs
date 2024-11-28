namespace Calculator
{
    partial class Calculator
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
            tbxDisplay = new TextBox();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnCalculate = new Button();
            btnClear = new Button();
            btnZero = new Button();
            SuspendLayout();
            // 
            // tbxDisplay
            // 
            tbxDisplay.Font = new Font("Segoe UI", 16F);
            tbxDisplay.Location = new Point(12, 12);
            tbxDisplay.Multiline = true;
            tbxDisplay.Name = "tbxDisplay";
            tbxDisplay.ReadOnly = true;
            tbxDisplay.ShortcutsEnabled = false;
            tbxDisplay.Size = new Size(347, 60);
            tbxDisplay.TabIndex = 0;
            tbxDisplay.TabStop = false;
            tbxDisplay.WordWrap = false;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(12, 78);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(80, 80);
            btnOne.TabIndex = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += ClickNumber;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(98, 78);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(80, 80);
            btnTwo.TabIndex = 2;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += ClickNumber;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThree.Location = new Point(184, 78);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(80, 80);
            btnThree.TabIndex = 3;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += ClickNumber;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSix.Location = new Point(184, 164);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(80, 80);
            btnSix.TabIndex = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += ClickNumber;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFive.Location = new Point(98, 164);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(80, 80);
            btnFive.TabIndex = 5;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += ClickNumber;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFour.Location = new Point(12, 164);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(80, 80);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += ClickNumber;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNine.Location = new Point(184, 250);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(80, 80);
            btnNine.TabIndex = 9;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += ClickNumber;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEight.Location = new Point(98, 250);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(80, 80);
            btnEight.TabIndex = 8;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += ClickNumber;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeven.Location = new Point(12, 250);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(80, 80);
            btnSeven.TabIndex = 7;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += ClickNumber;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(270, 78);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(92, 80);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += ClickOperator;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(270, 164);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(92, 80);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += ClickOperator;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(270, 250);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(92, 80);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += ClickOperator;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(270, 336);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(92, 80);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += ClickOperator;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(98, 336);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(80, 80);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "=";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += ClickCalculate;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(12, 336);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 79);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += ClickClear;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(184, 336);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(80, 80);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += ClickNumber;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(371, 427);
            Controls.Add(btnZero);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(tbxDisplay);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxDisplay;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnZero;
    }
}
