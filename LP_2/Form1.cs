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

            if (rtbIn.Text != null)
            {
                File.WriteAllText("input.txt", rtbIn.Text, Encoding.UTF8);
                TomitaWrapper t = new TomitaWrapper();
                t.FindFact();
            }

            rtbOut.Clear();
            //string fileName = Path.Combine(Properties.Settings.Default.SourceFolder, "output.txt");
            //String Folder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            //                         Properties.Settings.Default.SourceFolder);
            {
                //string fileName = Path.Combine(Folder,"output.txt");
                string fileName = "output.txt";
                if (File.Exists(fileName))
                {
                    var sr = new StreamReader(fileName, Encoding.UTF8);
                    string text = sr.ReadToEnd();
                    rtbOut.Clear();
                    rtbOut.AppendText(text);
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

        //открыть файл (путь указывает пользователь)
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFD = new OpenFileDialog();

            openFD.InitialDirectory = "с:\\";
            openFD.Filter = "txt files (*.txt)|*.txt";
            openFD.FilterIndex = 2;
            openFD.RestoreDirectory = true;

            if (openFD.ShowDialog() == DialogResult.OK)
            {


                string fileName = openFD.FileName;
                var sr = new StreamReader(fileName, Encoding.UTF8);
                string text = sr.ReadToEnd();
                rtbIn.Clear();
                rtbIn.AppendText(text);
                sr.Close();

            }

        }

        //открыть окно настроек
        private void Settings_Click(object sender, EventArgs e)
        {
            FormSettings Settings = new FormSettings();
            Settings.ShowDialog();
        }

        //выход из приложения
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //сохранение извлеченных фактов
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "txt files (*.txt)|*.txt";
            saveFD.FilterIndex = 2;
            saveFD.RestoreDirectory = true;


            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                rtbOut.SaveFile(saveFD.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
