using import.Core;
using System;
using System.IO;

namespace import
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader.ReadFile();


            //string projectRootPath = Environment.CurrentDirectory;
            //string fileName = "CSGO Weapon Dataset.csv";
            //string datafilePath = projectRootPath + @"\Data\" + fileName;
            //Console.WriteLine(datafilePath);

            //using (StreamReader s = new StreamReader(datafilePath))
            //{
            //    for (int i = 0; !s.EndOfStream; i++)
            //    {
            //        var line = s.ReadLine();
            //        if (i < 1) continue;

            //        var column = line.Split(";");
                    
            //        Console.WriteLine(column[0]);
            //    }


            //    Console.WriteLine(s);
            //}
        }
    }
}
