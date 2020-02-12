using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home5._3.Models
{
    public class Model : IModel, IMarker
    {
        private RichTextBox richText { get; set; }

        private string text { get; set; }


        public Model()
        {
            richText = new RichTextBox();
        }

        public RichTextBox RichText { get => richText; set => richText = value; }

        public string Text { get => text; set => text = value; }

        public void Open()
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|C++ files (*.cpp;*.h;*.hpp)|*.cpp;*.h;*.hpp|All files (*.*)|*.*";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                Text = fileDialog.FileName;
                var fileSteem = fileDialog.OpenFile();

                using(StreamReader reader = new StreamReader(Text, System.Text.Encoding.Default))
                {
                    RichText.Text = reader.ReadToEnd();
                }
            }
        }

        public void Save()
        {
            Stream fileSteem;
            var fileDialog = new SaveFileDialog();

            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

           // if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileSteem = fileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(Text);
                sw.Write(RichText.Text);

                sw.Close();
                fileSteem.Close();
            }
        }

        public void SaveAs()
        {
            Stream fileSteem;
            var fileDialog = new SaveFileDialog();

            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileSteem = fileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fileSteem);
                sw.Write(RichText.Text);

                sw.Close();
                fileSteem.Close();
            }
        }

        public void Color()
        {

        }

        public void Font()
        {

        }
    }
}
