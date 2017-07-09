using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LP_2
{
    class TomitaWrapper
    {
        public void FindFact(/*String inputName, String grammName*/)
        {
            //Проблемы с путями не изменять!

            /*var startInfo = new ProcessStartInfo
            {
                //имя файла
                FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                            Path.Combine(Properties.Settings.Default.SourceFolder,
                                                    Properties.Settings.Default.TomitaFileName)),
                                                    
                
                //скрытое окно
                WindowStyle = ProcessWindowStyle.Hidden,
                //ваши аргументы
                Arguments = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                        Path.Combine(Properties.Settings.Default.SourceFolder, "config.proto"))
            };
            //запуск процесса
            
            startInfo.WorkingDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                       Properties.Settings.Default.SourceFolder);
            //startInfo.WorkingDirectory = Properties.Settings.Default.SourceFolder;
            String oldInputPath = Path.Combine(startInfo.WorkingDirectory, "input.txt");
            String oldGrammPath = Path.Combine(startInfo.WorkingDirectory, "first.cxx");
            String newInputPath = Path.Combine(startInfo.WorkingDirectory, inputName);
            String newGrammPath = Path.Combine(startInfo.WorkingDirectory, grammName);
            String outputPath = Path.Combine(startInfo.WorkingDirectory, "output.txt"); 
            File.Copy(newInputPath, oldInputPath,true);
            File.Copy(newGrammPath, oldGrammPath,true);
            File.Delete(outputPath);
            startInfo.UserName = null;
            //Process.Start(startInfo);

            Process pr = new Process();
            //pr.StartInfo = new ProcessStartInfo("tomitaparser.exe", "config.proto");
            pr.StartInfo = startInfo;
            pr.Start();
            pr.WaitForExit();//ожидание завершения
            //удаление лишних файлов
            //File.Delete("first.bin");
            //File.Delete("dic.gzt.bin");
            //File.Delete("output.txt");
            */

            Process pr = new Process();
            pr.StartInfo = new ProcessStartInfo("tomitaparser.exe", "config.proto");
            pr.Start();
            pr.WaitForExit();

        }
    }
}