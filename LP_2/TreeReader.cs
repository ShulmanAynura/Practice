using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP_2
{
    static class TreeReader
    {
        static public List<TreeNode> read(String filename)
        {
            List < TreeNode > result = new List<TreeNode>();
            TreeNode root = new TreeNode("Facts");
            result.Add(root);
            int n = 0;  
            FileStream inFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(inFile);
            TreeNode fact = new TreeNode();
            bool flagFact = false;
            bool flagOpen = false;
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine().Trim();
                flagFact = false;
                flagOpen = false;
                
                foreach (String str in line.Split(' '))
                {
                    if (str == "Fact")
                        flagFact = true;
                    if (str == "{")
                        flagOpen = true;
                }
                if (flagFact == true)
                {
                    n++;
                    fact = new TreeNode("Fact"+n);
                    root.Nodes.Add(fact);
                    result.Add(fact);
                }
                if (flagOpen)
                {
                    while (line.Trim() != "}")
                    {
                        line = sr.ReadLine().Trim();
                        String[] s = line.Split('=');
                        if (s.Length > 1)
                        {
                            TreeNode field = new TreeNode(s[1]);
                            fact.Nodes.Add(field);
                            result.Add(field);
                        }
                    }
                }

            }
            sr.Close();
            inFile.Close();
            return result;
        }
    }
}
