using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace ProgressBarSample
{
    public partial class MainForm : Form
    {
        /*1. Написать приложение, которое отображает количество
             текста, прочитанного из файла с помощью ProgressBar.*/
        public MainForm()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBarText.Value = listBox.Items.Count;
        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            progressBarText.Value++;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (progressBarText.Value != progressBarText.Maximum)
            {
                long i;
                FileStream fin = null;
                /*FileStream fin2;    // для создания файла

                List<string> listt = new List<string>();

                listt.Add("cefrvrgr");
                listt.Add("cefrvrgr");
                listt.Add("cefrvrgr");
                fin2 = new FileStream("F2.data", FileMode.Create);
                for (int k = 0; k < listt.Count; k++)
                {
                    for (int j = 0; j < listt[k].Length; j++)
                    {
                        fin2.WriteByte((byte)listt[k][j]);
                    }
                    fin2.WriteByte((byte)'\n');
                }
                fin2.Close();*/

                try
                {
                    fin = new FileStream("F2.data", FileMode.Open);
                }
                catch (IOException exc)
                {
                    listBox.Items.Add(exc.Message);
                }

                if (fin != null)
                {
                    progressBarText.Maximum = (int)fin.Length;
                    progressBarText.Step = 1;
                    string line = string.Empty;
                    try
                    {
                        do
                        {
                            i = fin.ReadByte();
                            if (i != -1)
                            {
                                progressBarText.Value += progressBarText.Step;
                                line = line + (char)i;
                                if ((char)i == '\n')
                                {
                                    listBox.Items.Add(line);
                                    line = string.Empty;
                                }
                            }
                        } while (i != -1);

                    }
                    catch (IOException exc)
                    {
                        listBox.Items.Add("Error Reading File");
                        listBox.Items.Add(exc.Message);
                    }
                    finally
                    {
                        fin.Close();
                        fin = null;
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
