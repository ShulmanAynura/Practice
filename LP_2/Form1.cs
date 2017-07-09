using System;
using System.Reflection;
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
            //TomitaWrapper t = new TomitaWrapper();
            //t.FindFact();  
            
            if ((toolStripComboBox1.SelectedIndex>-1)&& (toolStripComboBox2.SelectedIndex > -1))
                TomitaWrapper.FindFact(toolStripComboBox1.Text, toolStripComboBox2.Text);

            rtbOut.Clear();
            //string fileName = Path.Combine(Properties.Settings.Default.SourceFolder, "output.txt");
            String Folder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                       Properties.Settings.Default.SourceFolder);
            {
                string fileName = Path.Combine(Folder,"output.txt");
                if (File.Exists(fileName))
                {
                    var sr = new StreamReader(fileName, Encoding.UTF8);
                    string text = sr.ReadToEnd();
                    rtbOut.Clear();
                    rtbOut.AppendText(text);
                    sr.Close();
                }
            }

            {
                string fileName = Path.Combine(Folder, "input.txt");
                if (File.Exists(fileName))
                {
                    var sr = new StreamReader(fileName, Encoding.UTF8);
                    string text = sr.ReadToEnd();
                    rtbIn.Clear();
                    rtbIn.AppendText(text);
                    sr.Close();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            rtbOut.Width = Form1.ActiveForm.Width / 2-15;
            rtbIn.Width = Form1.ActiveForm.Width / 2-15;
          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rtbOut.Width = Form1.ActiveForm.Width / 2 - 15;
            rtbIn.Width = Form1.ActiveForm.Width / 2 - 15;
        }


    }
}
