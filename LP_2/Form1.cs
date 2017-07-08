using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TomitaWrapper t = new TomitaWrapper();
            t.FindFact();

            

            richTextBox1.Clear();
            //string fileName = Path.Combine(Properties.Settings.Default.SourceFolder, "output.txt");
            string fileName = "output.txt";
            if (File.Exists(fileName))
            {
                var sr = new StreamReader(fileName, Encoding.UTF8);
                string text = sr.ReadToEnd();
                richTextBox1.AppendText(text);
                sr.Close();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            richTextBox1.Width = Form1.ActiveForm.Width / 2-15;
            richTextBox2.Width = Form1.ActiveForm.Width / 2-15;
          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            richTextBox1.Width = Form1.ActiveForm.Width / 2 - 15;
            richTextBox2.Width = Form1.ActiveForm.Width / 2 - 15;
        }
    }
}
