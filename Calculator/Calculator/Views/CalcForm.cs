using Calculator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : System.Windows.Forms.Form, ICalcView
    {
        double result { get; set; }
        double firstNumber { get; set; }
        bool outNumber { get; set; }
        char sumbol { get; set; }
        string textBoxInNumber { get; set; }

        public event EventHandler InNumber;
        public event EventHandler Clien;
        public event EventHandler PlusAndProsent;
        public event EventHandler SumbolCalc;
        public event EventHandler Copy;
        public event EventHandler Paste;



        public double Result
        {
            get => result;
            set => result = value;
        }

        public double FirstNumber
        {
            get => firstNumber;
            set => firstNumber = value;
        }

        public bool OutNumber
        {
            get => outNumber;
            set => outNumber = value;
        }

        public char Sumbol
        {
            get => sumbol;
            set => sumbol = value;
        }

        public string TextBoxInNumber
        {
            get => textBoxInNumber;
            set => textBoxInNumber = value;
        }

        public CalcForm()
        {
            InitializeComponent();
            textBox.Text = "0";
            OutNumber = false;
            pasteToolStripMenuItem.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            InNumber(sender, EventArgs.Empty);
            textBox.Text = TextBoxInNumber;
        }

        private void button_Clien_Click(object sender, EventArgs e)
        {
            Clien(sender, EventArgs.Empty);
            textBox.Text = TextBoxInNumber;
            pasteToolStripMenuItem.Enabled = false;
        }

        private void buttonProsent_Click(object sender, EventArgs e)
        {
            PlusAndProsent(sender, EventArgs.Empty);
            textBox.Text = TextBoxInNumber;
        }

        private void buttonSumbol_Click(object sender, EventArgs e)
        {
            SumbolCalc(sender, EventArgs.Empty);
            if (OutNumber)
            {
                textBox.Text = TextBoxInNumber;
                OutNumber = false;
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Copy(sender, e);
            pasteToolStripMenuItem.Enabled = true;
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            Paste(sender, e);
            textBox.Text = TextBoxInNumber;
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void Digis_Click(object sender, EventArgs e)
        {

        }
    }
}
