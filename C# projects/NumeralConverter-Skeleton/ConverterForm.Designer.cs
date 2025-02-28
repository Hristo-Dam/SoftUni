namespace NumeralConverter
{
    partial class ConverterForm
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
            this.labelDecimalNumber = new System.Windows.Forms.Label();
            this.textBoxDecimalNumber = new System.Windows.Forms.TextBox();
            this.labelDecimalToBinary = new System.Windows.Forms.Label();
            this.textBoxDecimalToBinary = new System.Windows.Forms.TextBox();
            this.buttonDecimalToBinary = new System.Windows.Forms.Button();
            this.buttonDecimalToHex = new System.Windows.Forms.Button();
            this.textBoxDecimalToHex = new System.Windows.Forms.TextBox();
            this.labelDecimalToHex = new System.Windows.Forms.Label();
            this.buttonBinaryToHex = new System.Windows.Forms.Button();
            this.textBoxBinaryToHex = new System.Windows.Forms.TextBox();
            this.labelBinaryToHex = new System.Windows.Forms.Label();
            this.buttonBinaryToDecimal = new System.Windows.Forms.Button();
            this.textBoxBinaryToDecimal = new System.Windows.Forms.TextBox();
            this.labelBinaryToDecimal = new System.Windows.Forms.Label();
            this.textBoxBinaryNumber = new System.Windows.Forms.TextBox();
            this.labelBinaryNumber = new System.Windows.Forms.Label();
            this.buttonHexToBinary = new System.Windows.Forms.Button();
            this.textBoxHexToBinary = new System.Windows.Forms.TextBox();
            this.labelHexToBinary = new System.Windows.Forms.Label();
            this.buttonHexToDecimal = new System.Windows.Forms.Button();
            this.textBoxHexToDecimal = new System.Windows.Forms.TextBox();
            this.labelHexToDecimal = new System.Windows.Forms.Label();
            this.textBoxHexNumber = new System.Windows.Forms.TextBox();
            this.labelHexNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDecimalNumber
            // 
            this.labelDecimalNumber.AutoSize = true;
            this.labelDecimalNumber.Location = new System.Drawing.Point(12, 9);
            this.labelDecimalNumber.Name = "labelDecimalNumber";
            this.labelDecimalNumber.Size = new System.Drawing.Size(100, 15);
            this.labelDecimalNumber.TabIndex = 0;
            this.labelDecimalNumber.Text = "Decimal Number:";
            // 
            // textBoxDecimalNumber
            // 
            this.textBoxDecimalNumber.Location = new System.Drawing.Point(12, 27);
            this.textBoxDecimalNumber.Name = "textBoxDecimalNumber";
            this.textBoxDecimalNumber.Size = new System.Drawing.Size(167, 23);
            this.textBoxDecimalNumber.TabIndex = 1;
            // 
            // labelDecimalToBinary
            // 
            this.labelDecimalToBinary.AutoSize = true;
            this.labelDecimalToBinary.Location = new System.Drawing.Point(185, 9);
            this.labelDecimalToBinary.Name = "labelDecimalToBinary";
            this.labelDecimalToBinary.Size = new System.Drawing.Size(58, 15);
            this.labelDecimalToBinary.TabIndex = 2;
            this.labelDecimalToBinary.Text = "To Binary:";
            // 
            // textBoxDecimalToBinary
            // 
            this.textBoxDecimalToBinary.Location = new System.Drawing.Point(185, 27);
            this.textBoxDecimalToBinary.Name = "textBoxDecimalToBinary";
            this.textBoxDecimalToBinary.ReadOnly = true;
            this.textBoxDecimalToBinary.Size = new System.Drawing.Size(167, 23);
            this.textBoxDecimalToBinary.TabIndex = 3;
            // 
            // buttonDecimalToBinary
            // 
            this.buttonDecimalToBinary.Location = new System.Drawing.Point(358, 27);
            this.buttonDecimalToBinary.Name = "buttonDecimalToBinary";
            this.buttonDecimalToBinary.Size = new System.Drawing.Size(69, 23);
            this.buttonDecimalToBinary.TabIndex = 4;
            this.buttonDecimalToBinary.Text = "Convert";
            this.buttonDecimalToBinary.UseVisualStyleBackColor = true;
            this.buttonDecimalToBinary.Click += new System.EventHandler(this.ButtonDecimalToBinary_Click);
            // 
            // buttonDecimalToHex
            // 
            this.buttonDecimalToHex.Location = new System.Drawing.Point(358, 76);
            this.buttonDecimalToHex.Name = "buttonDecimalToHex";
            this.buttonDecimalToHex.Size = new System.Drawing.Size(69, 23);
            this.buttonDecimalToHex.TabIndex = 9;
            this.buttonDecimalToHex.Text = "Convert";
            this.buttonDecimalToHex.UseVisualStyleBackColor = true;
            this.buttonDecimalToHex.Click += new System.EventHandler(this.ButtonDecimalToHex_Click);
            // 
            // textBoxDecimalToHex
            // 
            this.textBoxDecimalToHex.Location = new System.Drawing.Point(185, 76);
            this.textBoxDecimalToHex.Name = "textBoxDecimalToHex";
            this.textBoxDecimalToHex.ReadOnly = true;
            this.textBoxDecimalToHex.Size = new System.Drawing.Size(167, 23);
            this.textBoxDecimalToHex.TabIndex = 8;
            // 
            // labelDecimalToHex
            // 
            this.labelDecimalToHex.AutoSize = true;
            this.labelDecimalToHex.Location = new System.Drawing.Point(185, 58);
            this.labelDecimalToHex.Name = "labelDecimalToHex";
            this.labelDecimalToHex.Size = new System.Drawing.Size(46, 15);
            this.labelDecimalToHex.TabIndex = 7;
            this.labelDecimalToHex.Text = "To Hex:";
            // 
            // buttonBinaryToHex
            // 
            this.buttonBinaryToHex.Location = new System.Drawing.Point(358, 188);
            this.buttonBinaryToHex.Name = "buttonBinaryToHex";
            this.buttonBinaryToHex.Size = new System.Drawing.Size(69, 23);
            this.buttonBinaryToHex.TabIndex = 17;
            this.buttonBinaryToHex.Text = "Convert";
            this.buttonBinaryToHex.UseVisualStyleBackColor = true;
            this.buttonBinaryToHex.Click += new System.EventHandler(this.ButtonBinaryToHex_Click);
            // 
            // textBoxBinaryToHex
            // 
            this.textBoxBinaryToHex.Location = new System.Drawing.Point(185, 188);
            this.textBoxBinaryToHex.Name = "textBoxBinaryToHex";
            this.textBoxBinaryToHex.ReadOnly = true;
            this.textBoxBinaryToHex.Size = new System.Drawing.Size(167, 23);
            this.textBoxBinaryToHex.TabIndex = 16;
            // 
            // labelBinaryToHex
            // 
            this.labelBinaryToHex.AutoSize = true;
            this.labelBinaryToHex.Location = new System.Drawing.Point(185, 170);
            this.labelBinaryToHex.Name = "labelBinaryToHex";
            this.labelBinaryToHex.Size = new System.Drawing.Size(46, 15);
            this.labelBinaryToHex.TabIndex = 15;
            this.labelBinaryToHex.Text = "To Hex:";
            // 
            // buttonBinaryToDecimal
            // 
            this.buttonBinaryToDecimal.Location = new System.Drawing.Point(358, 139);
            this.buttonBinaryToDecimal.Name = "buttonBinaryToDecimal";
            this.buttonBinaryToDecimal.Size = new System.Drawing.Size(69, 23);
            this.buttonBinaryToDecimal.TabIndex = 14;
            this.buttonBinaryToDecimal.Text = "Convert";
            this.buttonBinaryToDecimal.UseVisualStyleBackColor = true;
            this.buttonBinaryToDecimal.Click += new System.EventHandler(this.ButtonBinaryToDecimal_Click);
            // 
            // textBoxBinaryToDecimal
            // 
            this.textBoxBinaryToDecimal.Location = new System.Drawing.Point(185, 139);
            this.textBoxBinaryToDecimal.Name = "textBoxBinaryToDecimal";
            this.textBoxBinaryToDecimal.ReadOnly = true;
            this.textBoxBinaryToDecimal.Size = new System.Drawing.Size(167, 23);
            this.textBoxBinaryToDecimal.TabIndex = 13;
            // 
            // labelBinaryToDecimal
            // 
            this.labelBinaryToDecimal.AutoSize = true;
            this.labelBinaryToDecimal.Location = new System.Drawing.Point(185, 121);
            this.labelBinaryToDecimal.Name = "labelBinaryToDecimal";
            this.labelBinaryToDecimal.Size = new System.Drawing.Size(68, 15);
            this.labelBinaryToDecimal.TabIndex = 12;
            this.labelBinaryToDecimal.Text = "To Decimal:";
            // 
            // textBoxBinaryNumber
            // 
            this.textBoxBinaryNumber.Location = new System.Drawing.Point(12, 139);
            this.textBoxBinaryNumber.Name = "textBoxBinaryNumber";
            this.textBoxBinaryNumber.Size = new System.Drawing.Size(167, 23);
            this.textBoxBinaryNumber.TabIndex = 11;
            // 
            // labelBinaryNumber
            // 
            this.labelBinaryNumber.AutoSize = true;
            this.labelBinaryNumber.Location = new System.Drawing.Point(12, 121);
            this.labelBinaryNumber.Name = "labelBinaryNumber";
            this.labelBinaryNumber.Size = new System.Drawing.Size(90, 15);
            this.labelBinaryNumber.TabIndex = 10;
            this.labelBinaryNumber.Text = "Binary Number:";
            // 
            // buttonHexToBinary
            // 
            this.buttonHexToBinary.Location = new System.Drawing.Point(358, 297);
            this.buttonHexToBinary.Name = "buttonHexToBinary";
            this.buttonHexToBinary.Size = new System.Drawing.Size(69, 23);
            this.buttonHexToBinary.TabIndex = 25;
            this.buttonHexToBinary.Text = "Convert";
            this.buttonHexToBinary.UseVisualStyleBackColor = true;
            this.buttonHexToBinary.Click += new System.EventHandler(this.ButtonHexToBinary_Click);
            // 
            // textBoxHexToBinary
            // 
            this.textBoxHexToBinary.Location = new System.Drawing.Point(185, 297);
            this.textBoxHexToBinary.Name = "textBoxHexToBinary";
            this.textBoxHexToBinary.ReadOnly = true;
            this.textBoxHexToBinary.Size = new System.Drawing.Size(167, 23);
            this.textBoxHexToBinary.TabIndex = 24;
            // 
            // labelHexToBinary
            // 
            this.labelHexToBinary.AutoSize = true;
            this.labelHexToBinary.Location = new System.Drawing.Point(185, 279);
            this.labelHexToBinary.Name = "labelHexToBinary";
            this.labelHexToBinary.Size = new System.Drawing.Size(58, 15);
            this.labelHexToBinary.TabIndex = 23;
            this.labelHexToBinary.Text = "To Binary:";
            // 
            // buttonHexToDecimal
            // 
            this.buttonHexToDecimal.Location = new System.Drawing.Point(358, 248);
            this.buttonHexToDecimal.Name = "buttonHexToDecimal";
            this.buttonHexToDecimal.Size = new System.Drawing.Size(69, 23);
            this.buttonHexToDecimal.TabIndex = 22;
            this.buttonHexToDecimal.Text = "Convert";
            this.buttonHexToDecimal.UseVisualStyleBackColor = true;
            this.buttonHexToDecimal.Click += new System.EventHandler(this.ButtonHexToDecimal_Click);
            // 
            // textBoxHexToDecimal
            // 
            this.textBoxHexToDecimal.Location = new System.Drawing.Point(185, 248);
            this.textBoxHexToDecimal.Name = "textBoxHexToDecimal";
            this.textBoxHexToDecimal.ReadOnly = true;
            this.textBoxHexToDecimal.Size = new System.Drawing.Size(167, 23);
            this.textBoxHexToDecimal.TabIndex = 21;
            // 
            // labelHexToDecimal
            // 
            this.labelHexToDecimal.AutoSize = true;
            this.labelHexToDecimal.Location = new System.Drawing.Point(185, 230);
            this.labelHexToDecimal.Name = "labelHexToDecimal";
            this.labelHexToDecimal.Size = new System.Drawing.Size(68, 15);
            this.labelHexToDecimal.TabIndex = 20;
            this.labelHexToDecimal.Text = "To Decimal:";
            // 
            // textBoxHexNumber
            // 
            this.textBoxHexNumber.Location = new System.Drawing.Point(12, 248);
            this.textBoxHexNumber.Name = "textBoxHexNumber";
            this.textBoxHexNumber.Size = new System.Drawing.Size(167, 23);
            this.textBoxHexNumber.TabIndex = 19;
            // 
            // labelHexNumber
            // 
            this.labelHexNumber.AutoSize = true;
            this.labelHexNumber.Location = new System.Drawing.Point(12, 230);
            this.labelHexNumber.Name = "labelHexNumber";
            this.labelHexNumber.Size = new System.Drawing.Size(78, 15);
            this.labelHexNumber.TabIndex = 18;
            this.labelHexNumber.Text = "Hex Number:";
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 333);
            this.Controls.Add(this.buttonHexToBinary);
            this.Controls.Add(this.textBoxHexToBinary);
            this.Controls.Add(this.labelHexToBinary);
            this.Controls.Add(this.buttonHexToDecimal);
            this.Controls.Add(this.textBoxHexToDecimal);
            this.Controls.Add(this.labelHexToDecimal);
            this.Controls.Add(this.textBoxHexNumber);
            this.Controls.Add(this.labelHexNumber);
            this.Controls.Add(this.buttonBinaryToHex);
            this.Controls.Add(this.textBoxBinaryToHex);
            this.Controls.Add(this.labelBinaryToHex);
            this.Controls.Add(this.buttonBinaryToDecimal);
            this.Controls.Add(this.textBoxBinaryToDecimal);
            this.Controls.Add(this.labelBinaryToDecimal);
            this.Controls.Add(this.textBoxBinaryNumber);
            this.Controls.Add(this.labelBinaryNumber);
            this.Controls.Add(this.buttonDecimalToHex);
            this.Controls.Add(this.textBoxDecimalToHex);
            this.Controls.Add(this.labelDecimalToHex);
            this.Controls.Add(this.buttonDecimalToBinary);
            this.Controls.Add(this.textBoxDecimalToBinary);
            this.Controls.Add(this.labelDecimalToBinary);
            this.Controls.Add(this.textBoxDecimalNumber);
            this.Controls.Add(this.labelDecimalNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConverterForm";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDecimalNumber;
        private TextBox textBoxDecimalNumber;
        private Label labelDecimalToBinary;
        private TextBox textBoxDecimalToBinary;
        private Button buttonDecimalToBinary;
        private Button buttonDecimalToHex;
        private TextBox textBoxDecimalToHex;
        private Label labelDecimalToHex;
        private Button buttonBinaryToHex;
        private TextBox textBoxBinaryToHex;
        private Label labelBinaryToHex;
        private Button buttonBinaryToDecimal;
        private TextBox textBoxBinaryToDecimal;
        private Label labelBinaryToDecimal;
        private TextBox textBoxBinaryNumber;
        private Label labelBinaryNumber;
        private Button buttonHexToBinary;
        private TextBox textBoxHexToBinary;
        private Label labelHexToBinary;
        private Button buttonHexToDecimal;
        private TextBox textBoxHexToDecimal;
        private Label labelHexToDecimal;
        private TextBox textBoxHexNumber;
        private Label labelHexNumber;
    }
}