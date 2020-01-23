namespace Import
{
    using Core.Entities;
    using Import.Helpers;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public static class FileReader
    {
        public static List<Weapon> ReadFileWeapons()
        {
            List<Weapon> weaponsList = new List<Weapon>();
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

                    weaponsList.Add(weapon);
                    
                }
                return weaponsList;
            }
        }

        public static List<WeaponImage> ReadFileWeaponsImage()
        {
            List<WeaponImage> weaponsImageList = new List<WeaponImage>();
            string projectRootPath = Environment.CurrentDirectory;
            string fileName = "CSGO_Weapon_Image_Dataset.csv";
            string datafilePath = projectRootPath + @"\Data\" + fileName;

            using (StreamReader s = new StreamReader(datafilePath))
            {
                for (int i = 0; !s.EndOfStream; i++)
                {
                    var line = s.ReadLine();
                    if (i < 1) continue;

                    var weapon = line.CreateWeaponImage(i);

                    weaponsImageList.Add(weapon);

                }
                return weaponsImageList;
            }
        }
    }
}
