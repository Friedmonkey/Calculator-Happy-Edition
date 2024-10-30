
namespace Calculator_Happy_Edition
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Field = new System.Windows.Forms.RichTextBox();
            this.Equals = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.MemoryPlus = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.MemoryRetrive = new System.Windows.Forms.Button();
            this.Operand = new System.Windows.Forms.Label();
            this.FullEquasion = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.RevertButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.Label();
            this.OperandSetting = new System.Windows.Forms.Label();
            this.CN = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Bitt = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.More = new System.Windows.Forms.Button();
            this.VarText = new System.Windows.Forms.Label();
            this.lblMem = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblBit = new System.Windows.Forms.Label();
            this.lblLastPressed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.ListView();
            this.Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Enabled = false;
            this.Field.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Field.Location = new System.Drawing.Point(12, 26);
            this.Field.Multiline = false;
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(193, 46);
            this.Field.TabIndex = 0;
            this.Field.Text = "";
            this.Field.TextChanged += new System.EventHandler(this.Field_TextChanged);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.Color.Coral;
            this.Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals.Location = new System.Drawing.Point(124, 281);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(50, 50);
            this.Equals.TabIndex = 1;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Equals_MouseClick);
            // 
            // Comma
            // 
            this.Comma.BackColor = System.Drawing.Color.Coral;
            this.Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comma.Location = new System.Drawing.Point(68, 282);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(50, 50);
            this.Comma.TabIndex = 2;
            this.Comma.Text = ".";
            this.Comma.UseVisualStyleBackColor = false;
            this.Comma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Comma_MouseClick);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.Coral;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(12, 282);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(50, 50);
            this.Zero.TabIndex = 3;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Zero_MouseClick);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.Coral;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(180, 282);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 50);
            this.Minus.TabIndex = 4;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minus_MouseClick);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Coral;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(180, 226);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 50);
            this.Plus.TabIndex = 8;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Plus_MouseClick);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.Coral;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(124, 226);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(50, 50);
            this.Three.TabIndex = 7;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Three_MouseClick);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.Coral;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(68, 226);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(50, 50);
            this.Two.TabIndex = 6;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Two_MouseClick);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.Coral;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(12, 226);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(50, 50);
            this.One.TabIndex = 5;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.MouseClick += new System.Windows.Forms.MouseEventHandler(this.One_MouseClick);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Coral;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(180, 170);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 12;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Divide_MouseClick);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.Coral;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(124, 170);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 50);
            this.Six.TabIndex = 11;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Six_MouseClick);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.Coral;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(68, 170);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 50);
            this.Five.TabIndex = 10;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Five_MouseClick);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.Coral;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(12, 170);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 50);
            this.Four.TabIndex = 9;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Four_MouseClick);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.Coral;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(180, 114);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(50, 50);
            this.Multiply.TabIndex = 16;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Multiply_MouseClick);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.Coral;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(124, 114);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(50, 50);
            this.Nine.TabIndex = 15;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Nine_MouseClick);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.Coral;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(68, 114);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(50, 50);
            this.Eight.TabIndex = 14;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Eight_MouseClick);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.Coral;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(12, 114);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 50);
            this.Seven.TabIndex = 13;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Seven_MouseClick);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Coral;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clear.Location = new System.Drawing.Point(12, 78);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 24);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clear_MouseClick);
            // 
            // MemoryPlus
            // 
            this.MemoryPlus.BackColor = System.Drawing.Color.Coral;
            this.MemoryPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryPlus.Location = new System.Drawing.Point(124, 78);
            this.MemoryPlus.Name = "MemoryPlus";
            this.MemoryPlus.Size = new System.Drawing.Size(50, 24);
            this.MemoryPlus.TabIndex = 18;
            this.MemoryPlus.Text = "M+";
            this.MemoryPlus.UseVisualStyleBackColor = false;
            this.MemoryPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MemoryPlus_MouseClick);
            // 
            // MemoryClear
            // 
            this.MemoryClear.BackColor = System.Drawing.Color.Coral;
            this.MemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryClear.Location = new System.Drawing.Point(68, 78);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(50, 24);
            this.MemoryClear.TabIndex = 19;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = false;
            this.MemoryClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MemoryClear_MouseClick);
            // 
            // MemoryRetrive
            // 
            this.MemoryRetrive.BackColor = System.Drawing.Color.Coral;
            this.MemoryRetrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryRetrive.Location = new System.Drawing.Point(180, 78);
            this.MemoryRetrive.Name = "MemoryRetrive";
            this.MemoryRetrive.Size = new System.Drawing.Size(50, 24);
            this.MemoryRetrive.TabIndex = 20;
            this.MemoryRetrive.Text = "MR";
            this.MemoryRetrive.UseVisualStyleBackColor = false;
            this.MemoryRetrive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MemoryRetrive_MouseClick);
            // 
            // Operand
            // 
            this.Operand.AutoSize = true;
            this.Operand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operand.Location = new System.Drawing.Point(211, 26);
            this.Operand.Name = "Operand";
            this.Operand.Size = new System.Drawing.Size(95, 25);
            this.Operand.TabIndex = 21;
            this.Operand.Text = "Operand";
            // 
            // FullEquasion
            // 
            this.FullEquasion.AutoSize = true;
            this.FullEquasion.Location = new System.Drawing.Point(12, 9);
            this.FullEquasion.Name = "FullEquasion";
            this.FullEquasion.Size = new System.Drawing.Size(67, 13);
            this.FullEquasion.TabIndex = 22;
            this.FullEquasion.Text = "FullEquasion";
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.DarkOrange;
            this.Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square.Location = new System.Drawing.Point(182, 378);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(50, 50);
            this.Square.TabIndex = 26;
            this.Square.Text = "²";
            this.Square.UseVisualStyleBackColor = false;
            this.Square.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Square_MouseClick);
            // 
            // SquareRoot
            // 
            this.SquareRoot.BackColor = System.Drawing.Color.DarkOrange;
            this.SquareRoot.Enabled = false;
            this.SquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot.Location = new System.Drawing.Point(14, 378);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(50, 50);
            this.SquareRoot.TabIndex = 25;
            this.SquareRoot.Text = "none";
            this.SquareRoot.UseVisualStyleBackColor = false;
            // 
            // RevertButton
            // 
            this.RevertButton.BackColor = System.Drawing.Color.DarkOrange;
            this.RevertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevertButton.Location = new System.Drawing.Point(126, 378);
            this.RevertButton.Name = "RevertButton";
            this.RevertButton.Size = new System.Drawing.Size(50, 50);
            this.RevertButton.TabIndex = 24;
            this.RevertButton.Text = "<-";
            this.RevertButton.UseVisualStyleBackColor = false;
            this.RevertButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RevertButton_MouseClick);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.DarkOrange;
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.Location = new System.Drawing.Point(70, 378);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(50, 50);
            this.HistoryButton.TabIndex = 23;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HistoryButton_MouseClick);
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Location = new System.Drawing.Point(59, 468);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(44, 13);
            this.Memory.TabIndex = 27;
            this.Memory.Text = "Memory";
            // 
            // OperandSetting
            // 
            this.OperandSetting.AutoSize = true;
            this.OperandSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperandSetting.Location = new System.Drawing.Point(76, 540);
            this.OperandSetting.Name = "OperandSetting";
            this.OperandSetting.Size = new System.Drawing.Size(162, 25);
            this.OperandSetting.TabIndex = 28;
            this.OperandSetting.Text = "OperandSetting";
            // 
            // CN
            // 
            this.CN.AutoSize = true;
            this.CN.Location = new System.Drawing.Point(88, 495);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(78, 13);
            this.CN.TabIndex = 29;
            this.CN.Text = "CurrentNumber";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Bitt
            // 
            this.Bitt.AutoSize = true;
            this.Bitt.Location = new System.Drawing.Point(79, 516);
            this.Bitt.Name = "Bitt";
            this.Bitt.Size = new System.Drawing.Size(13, 13);
            this.Bitt.TabIndex = 30;
            this.Bitt.Text = "1";
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(8, 572);
            this.IpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(44, 13);
            this.IpLabel.TabIndex = 31;
            this.IpLabel.Text = "Unused";
            // 
            // More
            // 
            this.More.BackColor = System.Drawing.Color.Coral;
            this.More.Location = new System.Drawing.Point(14, 338);
            this.More.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(216, 27);
            this.More.TabIndex = 32;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = false;
            this.More.MouseClick += new System.Windows.Forms.MouseEventHandler(this.More_MouseClick);
            // 
            // VarText
            // 
            this.VarText.AutoSize = true;
            this.VarText.Location = new System.Drawing.Point(122, 572);
            this.VarText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VarText.Name = "VarText";
            this.VarText.Size = new System.Drawing.Size(88, 13);
            this.VarText.TabIndex = 33;
            this.VarText.Text = "Check for square";
            // 
            // lblMem
            // 
            this.lblMem.AutoSize = true;
            this.lblMem.Location = new System.Drawing.Point(8, 468);
            this.lblMem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMem.Name = "lblMem";
            this.lblMem.Size = new System.Drawing.Size(47, 13);
            this.lblMem.TabIndex = 34;
            this.lblMem.Text = "Memory:";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(8, 495);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(82, 13);
            this.lblCurrent.TabIndex = 35;
            this.lblCurrent.Text = "Current number:";
            // 
            // lblBit
            // 
            this.lblBit.AutoSize = true;
            this.lblBit.Location = new System.Drawing.Point(8, 516);
            this.lblBit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBit.Name = "lblBit";
            this.lblBit.Size = new System.Drawing.Size(69, 13);
            this.lblBit.TabIndex = 36;
            this.lblBit.Text = "Pressed Key:";
            // 
            // lblLastPressed
            // 
            this.lblLastPressed.AutoSize = true;
            this.lblLastPressed.Location = new System.Drawing.Point(5, 540);
            this.lblLastPressed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastPressed.Name = "lblLastPressed";
            this.lblLastPressed.Size = new System.Drawing.Size(71, 13);
            this.lblLastPressed.TabIndex = 37;
            this.lblLastPressed.Text = "Last Pressed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Make the window bigger for debug info";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 19);
            this.button1.TabIndex = 39;
            this.button1.Text = "V";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // History
            // 
            this.History.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.History.AutoArrange = false;
            this.History.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col});
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.HideSelection = false;
            this.History.LabelWrap = false;
            this.History.Location = new System.Drawing.Point(243, 78);
            this.History.Margin = new System.Windows.Forms.Padding(1);
            this.History.MultiSelect = false;
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(206, 288);
            this.History.TabIndex = 40;
            this.History.TileSize = new System.Drawing.Size(50, 1);
            this.History.UseCompatibleStateImageBehavior = false;
            this.History.View = System.Windows.Forms.View.Details;
            this.History.MouseClick += new System.Windows.Forms.MouseEventHandler(this.History_MouseClick);
            this.History.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.History_MouseDoubleClick);
            // 
            // Col
            // 
            this.Col.Text = "Equasion";
            this.Col.Width = 200;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(362, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 46);
            this.button2.TabIndex = 41;
            this.button2.Text = "Clear history";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Coral;
            this.Close.Location = new System.Drawing.Point(292, 26);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(66, 46);
            this.Close.TabIndex = 42;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MouseClick);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.Brown;
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearAll.Location = new System.Drawing.Point(362, 410);
            this.ClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(86, 43);
            this.ClearAll.TabIndex = 43;
            this.ClearAll.Text = "CLEAR ALL";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearAll_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(457, 593);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.History);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastPressed);
            this.Controls.Add(this.lblBit);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblMem);
            this.Controls.Add(this.VarText);
            this.Controls.Add(this.More);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.Bitt);
            this.Controls.Add(this.CN);
            this.Controls.Add(this.OperandSetting);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.RevertButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.FullEquasion);
            this.Controls.Add(this.Operand);
            this.Controls.Add(this.MemoryRetrive);
            this.Controls.Add(this.MemoryClear);
            this.Controls.Add(this.MemoryPlus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Field);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(260, 414);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Field;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button MemoryPlus;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Button MemoryRetrive;
        private System.Windows.Forms.Label Operand;
        private System.Windows.Forms.Label FullEquasion;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button RevertButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Label Memory;
        private System.Windows.Forms.Label OperandSetting;
        private System.Windows.Forms.Label CN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Bitt;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Label VarText;
        private System.Windows.Forms.Label lblMem;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblBit;
        private System.Windows.Forms.Label lblLastPressed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView History;
        private System.Windows.Forms.ColumnHeader Col;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button ClearAll;
    }
}

