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

            if (File.Exists("first.cxx"))
            {
                StreamReader srGramm = new StreamReader("first.cxx", Encoding.UTF8);
                rtbGramm.Clear();
                rtbGramm.Text = srGramm.ReadToEnd();
                srGramm.Close();
            }
            else
            {
                MessageBox.Show("Исходный файл с грамматиками не обнаружен, откройте файл грамматики или создайте новый", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (File.Exists("fact_types.proto"))
            {
                StreamReader srFact = new StreamReader("fact_types.proto", Encoding.UTF8);
                rtbFact.Clear();
                rtbFact.Text = srFact.ReadToEnd();
                srFact.Close();
            }
            else
            {
                MessageBox.Show("Исходный файл с типами фактов не обнаружен, откройте файл фактов или создайте новый", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //если нет необходимых файлов (разобраться потом!)
            /*if (!File.Exists("dic.gzt"))
            {
                string dic= "encoding \"utf8\"; \n import \"base.proto\";\n import \"articles_base.proto\";\n import \"fact_types.proto\";\nTAuxDicArticle \"Грамматика\"\n{key ={ \"tomita:first.cxx\" type = CUSTOM}}";
                File.WriteAllText("dic.proto", dic, Encoding.UTF8);
            }

            if (!File.Exists("config.proto"))
            {
                string config = "encoding \"utf8\";\nTTextMinerConfig\n{Dictionary = \"dic.gzt\";\nInput = { File = \"input.txt\"}\nOutput = { File = \"output.txt\" Format = text}\nArticles =[{ Name = \"Грамматика\" }]\n Facts =[{ Name = \"Fact\" }]}";
                File.WriteAllText("config.proto", config, Encoding.UTF8);
            }*/
        }

        //сохранение изменений
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            File.WriteAllText("first.cxx", rtbGramm.Text, Encoding.UTF8);
            File.WriteAllText("fact_types.proto", rtbFact.Text, Encoding.UTF8);
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
