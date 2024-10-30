using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Calculator_Happy_Edition
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 b); //used to get numbers by pressing the actual keys
        static string kelLog = "";
        public Boolean blocked = false;
        public Boolean Extra = false;
        public Boolean ExtraH = false;
        public string cheche;
        public string OverflowERR = "Operation is too big, this is to stop crash!";
        public List<string> OldField = new List<string>();
        public List<string> OldOperand = new List<string>();
        public List<string> OldSetting = new List<string>();
        public List<string> OldCN = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Loadform() 
        {
            OldField.Insert(0,"69*6+6");
            OldOperand.Insert(0, "+");
            OldSetting.Insert(0, "6");
            OldCN.Insert(0, "6");
            History.Items.Insert(0, "69*6+6" + " = " + "420");
            this.Size = new Size(258, 410);
            this.MinimumSize = new Size(258, 410);
            this.MaximumSize = new Size(258, 410);
            CN.Text = "";
            OperandSetting.Text = "";
            Memory.Text = "";
            Clearr();
        }
        //.............................................................................click-bits................................................/
        private void ClickNumber(string bttn)  //Whenever a number is clicked
        {
                CN.Text = CN.Text + bttn;
                OperandSetting.Text = bttn;
                Field.Text = Field.Text + bttn;
        }
        private void ClickOperand(string bttn) //whenever an operand is clicked
        {   
            string op = OperandSetting.Text;
            if (string.IsNullOrEmpty(Field.Text))
            {
                FullEquasion.Text = "Cant start with an operand!";
            }
            else {
            if (bttn == ".")
            {
                if (CN.Text.Contains("."))
                {
                    FullEquasion.Text = "Current number already contains a \".\"";
                }
                else 
                {
                    CN.Text = CN.Text + bttn;
                    Field.Text = Field.Text + bttn;
                    OperandSetting.Text = bttn;
                    Operand.Text = bttn;
                }
            }
            else 
            {
                if (op == "+" || op == "-" || op == "*" || op == "/" || op == ".")
                {
                }
                else 
                {
                    CN.Text = "";
                    OperandSetting.Text = bttn;
                    Operand.Text = bttn;
                    Field.Text = Field.Text + bttn;
                }
            }
            }
        }
        //...........................................................................................end-click-bits..................................//
        private void Clearr() 
        { 
                Field.Text = "";
                FullEquasion.Text = "";
                Operand.Text = "";
                OperandSetting.Text = "";
                CN.Text = "";
        }
        //........................................................................................EQUALS............................................//
        private void equalz() //calculates the equasion
        {
            try
            {
                    string op = OperandSetting.Text;
                    if (op == "+" || op == "-" || op == "*" || op == "/" || op == ".")
                    {
                        FullEquasion.Text = "Missing argument!";
                    }
                    else
                    {
                    string ceech = Field.Text;
                    FullEquasion.Text = Field.Text;
                        var Equasion = Field.Text.Replace("A", VarText.Text);
                        var Equasion2 = Equasion.Replace("∞", "8");
                        try
                        {
                            Field.Text = new System.Data.DataTable().Compute(Equasion2.Replace("NaN", "0"), "").ToString();
                            OldField.Insert(0, ceech);
                            OldOperand.Insert(0, Operand.Text);
                            OldSetting.Insert(0, OperandSetting.Text);
                            OldCN.Insert(0, CN.Text);
                            History.Items.Insert(0,ceech+" = "+Field.Text);
                        }
                        catch (DivideByZeroException e)
                        {
                            FullEquasion.Text = "Cant divide by zero!";
                        }
                        if (Field.Text.Contains(","))
                        {
                            Field.Text = Field.Text.Replace(',', '.');
                        }
                    }
            }
            catch (OverflowException ez) //if the number is too big!
            {
                if (VarText.Text == "Square")
                {
                    Field.Text = cheche;
                    FullEquasion.Text = "Equasion result is too big";
                    VarText.Text = "SquareLarge";
                }
                else
                {
                    FullEquasion.Text = OverflowERR;
                }
            }
        }

        private void KeyToButton(int id) 
        {
            if (96 <= id && id <= 105) //Numpad Keys
            {
                var actual = id - 96;
                ClickNumber(actual + "");
            }
            if (48 <= id && id <= 57) //Top num Keys
            {
                var actual = id - 48;
                ClickNumber(actual + "");
            }
            if (id == 107)
            {
                ClickOperand("+");
            }
            if (id == 109)
            {
                ClickOperand("-");
            }
            if (id == 106)
            {
                ClickOperand("*");
            }
            if (id == 111)
            {
                ClickOperand("/");
            }
            if (id == 46) //delete
            {
                Clearr();
            }
            if (id == 13) //enter key
            {
                equalz();
            }
            if (id == 81) //q button
            {
                //LoadIp();
                //blocked = true;
            }
            if (id == 10000) 
            {
                
            }
            Bitt.Text = id + "";
        }
        private void Clear_MouseClick(object sender, EventArgs e)
        {
            Clearr();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loadform();
        }
        //............................................................Memory-Bits..........................................................//
        private void MemoryPlus_MouseClick(object sender, EventArgs e) //add to memory
        {
            if (!string.IsNullOrEmpty(Field.Text))
            { 
                try
                {
                    string op = OperandSetting.Text;
                    if (op == "+" || op == "-" || op == "*" || op == "/" || op == ".")
                    {
                        FullEquasion.Text = "Cant save Memory! (Missing Argument)";
                    }
                    else
                    {
                        FullEquasion.Text = Field.Text;
                        var Equasion = Field.Text.Replace("A", VarText.Text);
                        var Equasion2 = Equasion.Replace("∞", "8");
                        try
                        {

                            Memory.Text = new System.Data.DataTable().Compute(Equasion2.Replace("NaN", "0"), "").ToString();
                        }
                        catch (DivideByZeroException ex)
                        {
                            FullEquasion.Text = "Cant divide by zero!";
                        }
                        if (Memory.Text.Contains(","))
                        {
                            Memory.Text = Memory.Text.Replace(',', '.');
                        }
                        FullEquasion.Text = "Memory saved!";
                    }
                }
                catch (OverflowException ez)
                {
                    FullEquasion.Text = OverflowERR;
                }
            }
        }

        private void MemoryClear_MouseClick(object sender, EventArgs e)
        {
            Memory.Text = "";
            FullEquasion.Text = "Memory cleared!";
        }

        private void MemoryRetrive_MouseClick(object sender, EventArgs e) //gets the memory
        {
            if (!string.IsNullOrEmpty(Memory.Text))
            {
                string op = OperandSetting.Text;
                if (Field.Text.Contains(".") && Memory.Text.Contains("."))
                {
                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        Field.Text = Field.Text + Memory.Text;
                        if (!string.IsNullOrEmpty(Memory.Text))
                            OperandSetting.Text = Memory.Text.Substring(Memory.Text.Length - 1);
                        CN.Text = CN.Text + Memory.Text;
                        FullEquasion.Text = "Memory retieved";
                    }
                    else
                    {
                        FullEquasion.Text = "Both memory and textfield contain a \".\"";
                    }
                }
                else
                {
                    Field.Text = Field.Text + Memory.Text;
                    if (!string.IsNullOrEmpty(Memory.Text))
                        OperandSetting.Text = Memory.Text.Substring(Memory.Text.Length - 1);
                    CN.Text = CN.Text + Memory.Text;
                    FullEquasion.Text = "Memory retieved";
                }
            }
            else 
            {
                FullEquasion.Text = "Memory is empty.";
            }
        }
        //...................................................................................end-Memory-Bits...........................................//
        private void Field_TextChanged(object sender, EventArgs e) //makes the font size smaller to fit the screen
        {
            if (Field.Text.Length >= 11)
            {
                Field.Font = new Font("MS Reference Sans Serif", 10);
                if (Field.Text.Length >= 22)
                {
                    Field.Font = new Font("MS Reference Sans Serif", 7);
                    if (Field.Text.Length >= 27)
                    {
                        Field.Multiline = true;
                    }
                }
            }
            else 
            {
                Field.Font = new Font("MS Reference Sans Serif", 18);
                Field.Multiline = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int b = 1; b < 127; b++) 
            {
                int KeyState = GetAsyncKeyState(b);
                if (KeyState == 32769) 
                {
                    KeyToButton(b);
                    //lblLastPressed.Text = b.ToString();
                }
            }
        }
        //................................................................................Start-more-bits...........................................................//
        private void Square_MouseClick(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(Field.Text))
                {
                    string op = OperandSetting.Text;
                    if (op == "+" || op == "-" || op == "*" || op == "/" || op == ".")
                    {
                        FullEquasion.Text = "Cant get the square of an operand";
                    }
                    else
                    {
                        cheche = Field.Text;
                        Field.Text = cheche + "*" + cheche;
                        VarText.Text = "Square";
                        equalz();
                        if (VarText.Text != "SquareLarge")
                            FullEquasion.Text = cheche + "²";
                    }
                }
                else
                {
                    FullEquasion.Text = "Cant get the square of $NULL";
                }
        }
        private void More_MouseClick(object sender, MouseEventArgs e)
        {
            Extra = !Extra;
            if (Extra) 
            {
                this.Size = new Size(this.Size.Width, 500);
                this.MinimumSize = new Size(this.MinimumSize.Width, 500);
                this.MaximumSize = new Size(this.MaximumSize.Width, 650);
                this.More.BackColor = System.Drawing.Color.DarkOrange;
                More.Text = "Less";
            }
            if (!Extra) 
            {
                this.Size = new Size(this.Size.Width, 410);
                this.MinimumSize = new Size(this.MinimumSize.Width, 410);
                this.MaximumSize = new Size(this.MaximumSize.Width, 410);
                this.More.BackColor = System.Drawing.Color.Coral;
                More.Text = "More";
            }
        }
        private void ToggleHistory()
        {
            ExtraH = !ExtraH;
            if (ExtraH)
            {
                this.Size = new Size(480, this.Size.Height);
                this.MinimumSize = new Size(480, this.MinimumSize.Height);
                this.MaximumSize = new Size(480, this.MaximumSize.Height);
            }
            if (!ExtraH)
            {
                this.Size = new Size(258, this.Size.Height);
                this.MinimumSize = new Size(258, this.MinimumSize.Height);
                this.MaximumSize = new Size(258, this.MaximumSize.Height);
            }
        }
        private void ClearHistory()
        {
            OldField.Clear();
            OldOperand.Clear();
            OldSetting.Clear();
            OldCN.Clear();
            History.Clear();

            OldField.Insert(0, "69*6+6");
            OldOperand.Insert(0, "+");
            OldSetting.Insert(0, "6");
            OldCN.Insert(0, "6");

            History.Columns.Add("Equasion");
            History.Columns[0].Width = 200;
            History.Items.Insert(0, "69*6+6" + " = " + "420");
        }
        //.............................................................................................End-more-bits...........................................//
        private void One_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Two_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Three_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Four_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Five_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Six_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Seven_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Eight_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Nine_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Zero_MouseClick(object sender, MouseEventArgs e)
        {
            ClickNumber((sender as Button).Text); //Gets the text of the pressed button
        }

        private void Multiply_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOperand((sender as Button).Text); //Gets the pressed Operand
        }

        private void Divide_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOperand((sender as Button).Text); //Gets the pressed Operand
        }

        private void Plus_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOperand((sender as Button).Text); //Gets the pressed Operand
        }

        private void Minus_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOperand((sender as Button).Text); //Gets the pressed Operand
        }

        private void Comma_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOperand((sender as Button).Text); //Gets the pressed Operand
        }

        private void Equals_MouseClick(object sender, MouseEventArgs e)
        {
            equalz();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Size = new Size(this.Size.Width, 650);
        }

        private void RevertButton_MouseClick(object sender, MouseEventArgs e) //.......................................revert............................../
        {
            int pos = 0;

            Field.Text = OldField.ElementAt(pos);
            Operand.Text = OldOperand.ElementAt(pos);
            OperandSetting.Text = OldSetting.ElementAt(pos);
            CN.Text = OldCN.ElementAt(pos);
        }
        private void HistoryButton_MouseClick(object sender, MouseEventArgs e)
        {
            ToggleHistory();
        }

        private void History_MouseClick(object sender, MouseEventArgs e)
        {
            int pos = History.SelectedIndices[0];
            FullEquasion.Text = pos.ToString();
        }

        private void History_MouseDoubleClick(object sender, MouseEventArgs e) //Gets the history index and adds it to ur current
        {
            int pos = History.SelectedIndices[0];

            Field.Text = OldField.ElementAt(pos);
            Operand.Text = OldOperand.ElementAt(pos);
            OperandSetting.Text = OldSetting.ElementAt(pos);
            CN.Text = OldCN.ElementAt(pos);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            ClearHistory();
        }

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            ToggleHistory();
        }

        private void ClearAll_MouseClick(object sender, MouseEventArgs e)
        {
            ClearHistory();
            Clearr();
            Memory.Text = "";
        }
    }
}
