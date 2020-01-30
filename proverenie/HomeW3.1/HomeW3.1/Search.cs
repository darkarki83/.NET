using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeW3._1
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
            ButtonEnabledStart();
        }

        // методы для внутренего пользывания
        public void ButtonEnabledStart()
        {
            buttonSearch.Enabled = true;
            buttonAdd.Enabled = false;
        }

        public void ButtonEnabled()
        {
            buttonSearch.Enabled = false;
            buttonAdd.Enabled = true;
        }




        private void button_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = @"C:\",
                ShowNewFolderButton = false,
                Description = "Select folder to work with."
            };

            var openFileDialog1 = new OpenFileDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.InitialDirectory = folderBrowserDialog.SelectedPath;
            }

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = openFileDialog1.FileName;
                ButtonEnabled();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (textPath.Text.Length > 0)
            {
                textPath.Text = string.Empty;
                ButtonEnabledStart();
            }
            else
                Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ((mainForm)Owner).SetListFiles(textPath.Text);
            Close();
        }
    }
}
