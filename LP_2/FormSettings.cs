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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            if (File.Exists(Properties.Settings.Default.FileGrammName))
            {
                StreamReader srGramm = new StreamReader(Properties.Settings.Default.FileGrammName, Encoding.UTF8);
                rtbGramm.Clear();
                rtbGramm.Text = srGramm.ReadToEnd();
                srGramm.Close();
            }
            else
            {
                MessageBox.Show("Исходный файл с грамматиками не обнаружен, откройте файл грамматики или создайте новый", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (File.Exists(Properties.Settings.Default.FileFactName))
            {
                StreamReader srFact = new StreamReader(Properties.Settings.Default.FileFactName, Encoding.UTF8);
                rtbFact.Clear();
                rtbFact.Text = srFact.ReadToEnd();
                srFact.Close();
            }
            else
            {
                MessageBox.Show("Исходный файл с типами фактов не обнаружен, откройте файл фактов или создайте новый", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //если нет необходимых файлов (разобраться потом!)
            if (!File.Exists(Properties.Settings.Default.FileDictionaryName))
            {
                string dic= "encoding \"utf8\"; \r\n import \"base.proto\";\r\n import \"articles_base.proto\";\r\n import \"fact_types.proto\";\r\nTAuxDicArticle \"Грамматика\"\r\n{key ={ \"tomita:first.cxx\" type = CUSTOM}}";
                File.WriteAllText(Properties.Settings.Default.FileDictionaryName, dic, Encoding.UTF8);
            }

            if (!File.Exists(Properties.Settings.Default.FileConfigName))
            {
                string config = "encoding \"utf8\";\r\nTTextMinerConfig\r\n{Dictionary = \"dic.gzt\";\r\nInput = { File = \"input.txt\"}\r\nOutput = { File = \"output.txt\" Format = text}\r\nArticles =[{ Name = \"Грамматика\" }]\r\nFacts =[{ Name = \"Fact\" }]}";
                File.WriteAllText(Properties.Settings.Default.FileConfigName, config, Encoding.UTF8);
            }
        }

        //сохранение изменений
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Properties.Settings.Default.FileGrammName, rtbGramm.Text, Encoding.UTF8);
            File.WriteAllText(Properties.Settings.Default.FileFactName, rtbFact.Text, Encoding.UTF8);
            Close();
        }

        //открыть новый файл грамматик
        private void OpenGramm_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();

            openFD.InitialDirectory = "с:\\";
            openFD.Filter = "cxx files (*.cxx)|*.cxx";
            openFD.FilterIndex = 2;
            openFD.RestoreDirectory = true;

            if (openFD.ShowDialog() == DialogResult.OK)
            {


                string fileName = openFD.FileName;
                var sr = new StreamReader(fileName, Encoding.UTF8);
                string text = sr.ReadToEnd();
                rtbGramm.Clear();
                rtbGramm.AppendText(text);
                sr.Close();

            }
        }

        //открыть новый файл с типами фактов
        private void OpenFact_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();

            openFD.InitialDirectory = "с:\\";
            openFD.Filter = "proto files (*.proto)|*.proto";
            openFD.FilterIndex = 2;
            openFD.RestoreDirectory = true;

            if (openFD.ShowDialog() == DialogResult.OK)
            {


                string fileName = openFD.FileName;
                var sr = new StreamReader(fileName, Encoding.UTF8);
                string text = sr.ReadToEnd();
                rtbFact.Clear();
                rtbFact.AppendText(text);
                sr.Close();

            }
        }
    }
}
