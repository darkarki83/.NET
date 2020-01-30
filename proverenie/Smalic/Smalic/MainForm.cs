using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smalic
{
    public partial class MainForm : Form
    {
        private Point smile;
        public MainForm()
        {
            InitializeComponent();
            smile = center.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

            Text = e.Location.ToString() + "  " + center.Location.ToString();

            if ((smile.X < e.X + 10) && (smile.Y > e.Y - 10 || smile.Y < e.Y + 10))
            {
                if (smile.X < Width - 84)
                {
                    smile.X = (e.X + 10);
                    center.Location = smile;
                }
                /*else
                {
                    smile.Y = (e.Y - 10);
                    center.Location = smile;
                }*/
            }
            if ((smile.X < e.Y + 10) && (smile.X > e.X - 10 || smile.X > e.X + 10))
            {
                if (smile.Y > Width + 25)
                {
                    smile.Y = (e.Y + 10);
                    center.Location = smile;
                }
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
