namespace Calculator
{
    partial class fMain
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
            this.calcText = new System.Windows.Forms.TextBox();
            this.buttonCaret = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.charLabel = new System.Windows.Forms.Label();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcText
            // 
            this.calcText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcText.ForeColor = System.Drawing.Color.Black;
            this.calcText.Location = new System.Drawing.Point(12, 39);
            this.calcText.Multiline = true;
            this.calcText.Name = "calcText";
            this.calcText.Size = new System.Drawing.Size(260, 28);
            this.calcText.TabIndex = 0;
            // 
            // buttonCaret
            // 
            this.buttonCaret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCaret.Location = new System.Drawing.Point(12, 73);
            this.buttonCaret.Name = "buttonCaret";
            this.buttonCaret.Size = new System.Drawing.Size(50, 48);
            this.buttonCaret.TabIndex = 4;
            this.buttonCaret.Text = "x^2";
            this.buttonCaret.UseVisualStyleBackColor = true;
            this.buttonCaret.Click += new System.EventHandler(this.buttonCaret_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPercent.Location = new System.Drawing.Point(184, 73);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(88, 48);
            this.buttonPercent.TabIndex = 6;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(184, 127);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(88, 48);
            this.buttonPlus.TabIndex = 10;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSeven.Location = new System.Drawing.Point(12, 127);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(50, 48);
            this.buttonSeven.TabIndex = 11;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEight.Location = new System.Drawing.Point(68, 127);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(50, 48);
            this.buttonEight.TabIndex = 12;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNine.Location = new System.Drawing.Point(124, 127);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(50, 48);
            this.buttonNine.TabIndex = 13;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSix.Location = new System.Drawing.Point(124, 181);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(50, 48);
            this.buttonSix.TabIndex = 16;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFive.Location = new System.Drawing.Point(68, 181);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(50, 48);
            this.buttonFive.TabIndex = 15;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFour.Location = new System.Drawing.Point(12, 181);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(50, 48);
            this.buttonFour.TabIndex = 14;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonThree.Location = new System.Drawing.Point(124, 235);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(50, 48);
            this.buttonThree.TabIndex = 19;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTwo.Location = new System.Drawing.Point(68, 235);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(50, 48);
            this.buttonTwo.TabIndex = 18;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOne.Location = new System.Drawing.Point(12, 235);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(50, 48);
            this.buttonOne.TabIndex = 17;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(184, 181);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(88, 48);
            this.buttonMinus.TabIndex = 20;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(184, 235);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(88, 48);
            this.buttonDivide.TabIndex = 21;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Tomato;
            this.buttonEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEqual.ForeColor = System.Drawing.Color.White;
            this.buttonEqual.Location = new System.Drawing.Point(124, 289);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(50, 48);
            this.buttonEqual.TabIndex = 23;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZero.Location = new System.Drawing.Point(68, 289);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(50, 48);
            this.buttonZero.TabIndex = 25;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDot.Location = new System.Drawing.Point(12, 289);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(50, 48);
            this.buttonDot.TabIndex = 26;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiplication.Location = new System.Drawing.Point(184, 289);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(88, 48);
            this.buttonMultiplication.TabIndex = 27;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(124, 73);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(54, 48);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.BackColor = System.Drawing.SystemColors.Control;
            this.charLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charLabel.Location = new System.Drawing.Point(248, 11);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(0, 25);
            this.charLabel.TabIndex = 29;
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSquareRoot.Location = new System.Drawing.Point(68, 73);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(50, 48);
            this.buttonSquareRoot.TabIndex = 30;
            this.buttonSquareRoot.Text = "√";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.buttonSquareRoot_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 351);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonCaret);
            this.Controls.Add(this.calcText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox calcText;
        private Button buttonCaret;
        private Button buttonPercent;
        private Button buttonPlus;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonMinus;
        private Button buttonDivide;
        private Button buttonEqual;
        private Button buttonZero;
        private Button buttonDot;
        private Button buttonMultiplication;
        private Button buttonClear;
        private Label charLabel;
        private Button buttonSquareRoot;
    }
}