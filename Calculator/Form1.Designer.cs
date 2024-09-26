namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Three = new Button();
            Two = new Button();
            One = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Nine = new Button();
            Eight = new Button();
            Seven = new Button();
            Zero = new Button();
            Decimal = new Button();
            PosNeg = new Button();
            Equals = new Button();
            Substract = new Button();
            Add = new Button();
            Divide = new Button();
            Multiply = new Button();
            Clear = new Button();
            BackSpace = new Button();
            TL_Panel = new TableLayoutPanel();
            Pow = new Button();
            TEXT = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            TL_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Three
            // 
            Three.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Three.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Three.Location = new Point(3, 273);
            Three.Name = "Three";
            Three.Size = new Size(96, 84);
            Three.TabIndex = 1;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Two
            // 
            Two.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Two.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Two.Location = new Point(105, 273);
            Two.Name = "Two";
            Two.Size = new Size(96, 84);
            Two.TabIndex = 2;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // One
            // 
            One.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            One.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            One.Location = new Point(207, 273);
            One.Name = "One";
            One.Size = new Size(96, 84);
            One.TabIndex = 3;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Four
            // 
            Four.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Four.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Four.Location = new Point(207, 183);
            Four.Name = "Four";
            Four.Size = new Size(96, 84);
            Four.TabIndex = 4;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Five.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Five.Location = new Point(105, 183);
            Five.Name = "Five";
            Five.Size = new Size(96, 84);
            Five.TabIndex = 5;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Six.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Six.Location = new Point(3, 183);
            Six.Name = "Six";
            Six.Size = new Size(96, 84);
            Six.TabIndex = 6;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Nine
            // 
            Nine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Nine.Location = new Point(3, 93);
            Nine.MinimumSize = new Size(10, 10);
            Nine.Name = "Nine";
            Nine.Size = new Size(96, 84);
            Nine.TabIndex = 7;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Eight
            // 
            Eight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Eight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Eight.Location = new Point(105, 93);
            Eight.Name = "Eight";
            Eight.Size = new Size(96, 84);
            Eight.TabIndex = 8;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Seven
            // 
            Seven.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Seven.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Seven.Location = new Point(207, 93);
            Seven.Name = "Seven";
            Seven.Size = new Size(96, 84);
            Seven.TabIndex = 9;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Zero
            // 
            Zero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Zero.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Zero.Location = new Point(105, 363);
            Zero.Name = "Zero";
            Zero.Size = new Size(96, 85);
            Zero.TabIndex = 10;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Decimal
            // 
            Decimal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Decimal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Decimal.Location = new Point(207, 363);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(96, 85);
            Decimal.TabIndex = 11;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = true;
            Decimal.Click += Decimal_Click;
            // 
            // PosNeg
            // 
            PosNeg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PosNeg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PosNeg.Location = new Point(3, 363);
            PosNeg.Name = "PosNeg";
            PosNeg.Size = new Size(96, 85);
            PosNeg.TabIndex = 12;
            PosNeg.Text = "+/-";
            PosNeg.UseVisualStyleBackColor = true;
            PosNeg.Click += PosOrNeg_Click;
            // 
            // Equals
            // 
            Equals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Equals.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Equals.Location = new Point(309, 363);
            Equals.Name = "Equals";
            Equals.Size = new Size(96, 85);
            Equals.TabIndex = 13;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = true;
            Equals.Click += Equals_Click;
            // 
            // Substract
            // 
            Substract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Substract.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Substract.Location = new Point(309, 273);
            Substract.Name = "Substract";
            Substract.Size = new Size(96, 84);
            Substract.TabIndex = 14;
            Substract.Text = "-";
            Substract.UseVisualStyleBackColor = true;
            Substract.Click += Substract_Click;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Add.Location = new Point(309, 183);
            Add.Name = "Add";
            Add.Size = new Size(96, 84);
            Add.TabIndex = 15;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Divide
            // 
            Divide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Divide.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Divide.Location = new Point(309, 3);
            Divide.Name = "Divide";
            Divide.Size = new Size(96, 84);
            Divide.TabIndex = 16;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Multiply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Multiply.Location = new Point(309, 93);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(96, 84);
            Multiply.TabIndex = 17;
            Multiply.Text = "x";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Clear.AutoEllipsis = true;
            Clear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Clear.BackColor = Color.Transparent;
            Clear.Location = new Point(105, 3);
            Clear.Name = "Clear";
            Clear.Size = new Size(96, 84);
            Clear.TabIndex = 19;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // BackSpace
            // 
            BackSpace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackSpace.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackSpace.Location = new Point(207, 3);
            BackSpace.Name = "BackSpace";
            BackSpace.Size = new Size(96, 84);
            BackSpace.TabIndex = 20;
            BackSpace.Text = "BackSpace";
            BackSpace.UseVisualStyleBackColor = true;
            BackSpace.Click += BackSpace_Click;
            // 
            // TL_Panel
            // 
            TL_Panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TL_Panel.AutoSize = true;
            TL_Panel.BackColor = Color.Transparent;
            TL_Panel.ColumnCount = 4;
            TL_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TL_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TL_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TL_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TL_Panel.Controls.Add(Clear, 1, 0);
            TL_Panel.Controls.Add(BackSpace, 2, 0);
            TL_Panel.Controls.Add(Two, 1, 3);
            TL_Panel.Controls.Add(One, 2, 3);
            TL_Panel.Controls.Add(Substract, 3, 3);
            TL_Panel.Controls.Add(Add, 3, 2);
            TL_Panel.Controls.Add(Multiply, 3, 1);
            TL_Panel.Controls.Add(Divide, 3, 0);
            TL_Panel.Controls.Add(Four, 2, 2);
            TL_Panel.Controls.Add(Five, 1, 2);
            TL_Panel.Controls.Add(Equals, 3, 4);
            TL_Panel.Controls.Add(Nine, 0, 1);
            TL_Panel.Controls.Add(Decimal, 2, 4);
            TL_Panel.Controls.Add(Six, 0, 2);
            TL_Panel.Controls.Add(Zero, 1, 4);
            TL_Panel.Controls.Add(Three, 0, 3);
            TL_Panel.Controls.Add(PosNeg, 0, 4);
            TL_Panel.Controls.Add(Eight, 1, 1);
            TL_Panel.Controls.Add(Seven, 2, 1);
            TL_Panel.Controls.Add(Pow, 0, 0);
            TL_Panel.Location = new Point(31, 212);
            TL_Panel.Name = "TL_Panel";
            TL_Panel.RowCount = 5;
            TL_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TL_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TL_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TL_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TL_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TL_Panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TL_Panel.Size = new Size(408, 451);
            TL_Panel.TabIndex = 0;
            // 
            // Pow
            // 
            Pow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Pow.BackColor = Color.Transparent;
            Pow.Location = new Point(3, 3);
            Pow.Name = "Pow";
            Pow.Size = new Size(96, 84);
            Pow.TabIndex = 21;
            Pow.Text = "X^";
            Pow.UseVisualStyleBackColor = false;
            Pow.Click += Pow_Click;
            // 
            // TEXT
            // 
            TEXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TEXT.BackColor = Color.White;
            TEXT.BorderStyle = BorderStyle.None;
            TEXT.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT.ForeColor = SystemColors.WindowText;
            TEXT.Location = new Point(0, 0);
            TEXT.Multiline = true;
            TEXT.Name = "TEXT";
            TEXT.ReadOnly = true;
            TEXT.ShortcutsEnabled = false;
            TEXT.Size = new Size(485, 169);
            TEXT.TabIndex = 1;
            TEXT.Text = "0";
            TEXT.TextAlign = HorizontalAlignment.Right;
            TEXT.UseWaitCursor = true;
            TEXT.MouseClick += TEXT_MouseClick;
            TEXT.PreviewKeyDown += KeyPreview_Handler;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(485, 675);
            Controls.Add(TEXT);
            Controls.Add(TL_Panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 580);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            TopMost = true;
            SizeChanged += Form1_ResizeBeg;
            TL_Panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button One;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Zero;
        private Button Decimal;
        private Button PosNeg;
        private Button Equals;
        private Button Substract;
        private Button Add;
        private Button Divide;
        private Button Multiply;
        private Button Clear;
        private Button BackSpace;
        private Button Pow;
        private TableLayoutPanel TL_Panel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox TEXT;
    }


}