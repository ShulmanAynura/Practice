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
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            InitializeComponent();

            if (File.Exists("input.txt"))
            {
                var sr = new StreamReader("input.txt", Encoding.UTF8);
                string text = sr.ReadToEnd();
                rtbIn.Clear();
                rtbIn.AppendText(text);
                sr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("config.proto") || !File.Exists("dic.gzt"))
            {
                Settings_Click(sender, e);   
            }
            if (rtbIn.Text != null)
            {
                File.WriteAllText("input.txt", rtbIn.Text, Encoding.UTF8);
                TomitaWrapper t = TomitaSimpleFabrica.Get(Properties.Settings.Default.FileConfigName);
                t.FindFact();

                treeFact.Nodes.Clear();
                treeFact.Nodes.Add(TreeReader.read("output.txt")[0]);
                treeFact.ExpandAll();
            }
            else
            {
                MessageBox.Show("Исходный текст отсутствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                string fact = "";
                int n = treeFact.Nodes[0].Nodes.Count, n1 = 0;

                for (int i = 0; i < n; i++)
                {
                    n1 = treeFact.Nodes[0].Nodes[i].Nodes.Count;
                    for (int j = 0; j < n1; j++)
                    {
                        fact = fact + treeFact.Nodes[0].Nodes[i].Nodes[j].Text;
                    }
                    fact = fact + "\r\n";
                }

                File.WriteAllText(saveFD.FileName, fact, Encoding.UTF8);
            }
        }

       
    }
}
