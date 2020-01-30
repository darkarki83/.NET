using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeW4
{
    public partial class MainForm : Form
    {
        private Point pointFarst;

        private Point pointSecond;

        private int index = 0;

        public MainForm()
        {
            InitializeComponent();
            pointFarst = new Point();
            pointSecond = new Point();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointFarst = e.Location;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point temp = new Point();
                temp.X = (e.X > pointFarst.X ? e.X - pointFarst.X : pointFarst.X - e.X);
                temp.Y = (e.Y > pointFarst.Y ? e.Y - pointFarst.Y : pointFarst.Y - e.Y);

                if (temp.X > 100 && temp.Y > 100)
                {
                    index++;
                    pointSecond = e.Location;

                    Label label = new System.Windows.Forms.Label();
                    SuspendLayout();

                    label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    label.AutoSize = false;
                    label.MinimumSize = new System.Drawing.Size(100, 100);
                    label.Size = new System.Drawing.Size(pointSecond.X - pointFarst.X, pointSecond.Y - pointFarst.Y);
                    label.TabIndex = index;
                    label.Tag = index;
                    label.BorderStyle = BorderStyle.Fixed3D;
                    label.Location = new System.Drawing.Point(pointFarst.X, pointFarst.Y);
                    label.Text = label.Location.ToString()+ "\n Size.Width " + label.Size.Width.ToString() + "\n Size.Height " + label.Size.Height.ToString();
                    label.Name = "label";
                    label.Click += new System.EventHandler(label_Click);

                    label.DoubleClick += new System.EventHandler(label_DoubleClick);
                    Controls.Add(label);
                }
                else
                {
                    MessageBox.Show("our size need more 100 * 100", "SIZE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Text = sender.ToString();
            }
            /*Label temp = new Label();
            Label temp1 = new Label();

            if (e.Button == MouseButtons.Right)
            {
                foreach (var i in Controls)
                {
                    if (i is Label)
                    {
                        temp = i as Label;
                    }
                    if (temp.Location == e.Location) 
                    Text = temp.Tag.ToString();
                }
            }*/
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label temp = new Label();
            temp = (Label)sender;
            Text = temp.Location.ToString() + " Size " + temp.Size.Width.ToString() + " * " + temp.Size.Height.ToString() + " " + temp.TabIndex;
        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            Label temp = new Label();
            temp = (Label)sender;
            Controls.Remove(temp);
        }

    }
}
