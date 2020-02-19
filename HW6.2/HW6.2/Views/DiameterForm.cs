using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6._2
{
    public partial class DiameterForm : Form
    {
        public DiameterForm()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {

            ((MainForm)Owner).HeightCircle = int.Parse(numericDiameter.Value.ToString());
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
