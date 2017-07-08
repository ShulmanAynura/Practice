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
        public void FindFact()
        {
            var startInfo = new ProcessStartInfo
            {
                //имя файла
                FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                        Path.Combine(Properties.Settings.Default.SourceFolder,
                                                Properties.Settings.Default.TomitaFileName)),
                //скрытое окно
                //WindowStyle = ProcessWindowStyle.Hidden,
                //ваши аргументы
               Arguments = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                        Path.Combine(Properties.Settings.Default.SourceFolder, "config.proto"))
            };
            //запуск процесса
            startInfo.WorkingDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                       Properties.Settings.Default.SourceFolder);
            startInfo.UserName = null;
            //Process.Start(startInfo);

            string f = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                        Path.Combine(Properties.Settings.Default.SourceFolder,
                                                Properties.Settings.Default.TomitaFileName));
            string arg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                        Path.Combine(Properties.Settings.Default.SourceFolder, "config.proto"));

            Process pr = new Process();
            pr.StartInfo = new ProcessStartInfo("tomitaparser.exe", "config.proto");
            pr.Start();
            pr.WaitForExit();//ожидание завершения
           
            //удаление лишних файлов
            //File.Delete("first.bin");
            //File.Delete("dic.gzt.bin");
            //File.Delete("output.txt");

        }
    }
}