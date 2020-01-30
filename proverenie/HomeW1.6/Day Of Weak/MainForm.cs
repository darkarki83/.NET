using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_Of_Weak
{
    /*
     6. Написать программу, которая по введенной дате
        определяет день недели. Результат выводить в текстовое
        поле (желательно по-русски).*/
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = "MM.dd.yy";
            DateTime parsedDate;

            if (DateTime.TryParseExact(inputBox.Text, pattern, null,
                                              DateTimeStyles.None, out parsedDate))
                Console.WriteLine("Converted '{0}' to {1:d}.",
                                  inputBox.Text, parsedDate);
            else
                Console.WriteLine("Unable to convert '{0}' to a date and time.",
                                  inputBox.Text);

            if(e.KeyChar == (char)ConsoleKey.Enter)
            labelOut.Text = parsedDate.DayOfWeek.ToString();
        }
    }
}
