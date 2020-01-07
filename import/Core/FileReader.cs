using import.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace import.Core
{
    public static class FileReader
    {
        public static void ReadFile()
        {
            string projectRootPath = Environment.CurrentDirectory;
            string fileName = "CSGO Weapon Dataset.csv";
            string datafilePath = projectRootPath + @"\Data\" + fileName;

            using (StreamReader s = new StreamReader(datafilePath))
            {
                for (int i = 0; !s.EndOfStream; i++)
                {
                    var line = s.ReadLine();
                    if (i < 1) continue;

                    var weapon = line.CreateWeapon(i);

                    
                }


                
            }
        }
        
        
    }
}
