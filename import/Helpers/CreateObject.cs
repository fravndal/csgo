using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace import.Helpers
{
    public static class CreateObject
    {
        public static Weapon CreateWeapon(this string line, int id)
        {
            var column = line.Split(";");
            //var test = id;
            //var test2 = column[0];
            //var test3 = column[1];
            //var test4 = int.Parse(column[2].Replace("$", "").Trim());
            //var test5 = int.Parse(column[3].Replace("$", "").Trim());
            //var test6 = int.Parse(column[4]);
            //var test7 = int.Parse(column[5]);
            //var test8 = double.Parse(column[6].Replace("%", "").Trim());
            //var test9 = column[7];
            //var test10 = double.Parse(column[8].Replace("%", "").Trim());
            //var test11 = column[9];
            //var test12 = int.Parse(column[10]);
            //var test13 = int.Parse(column[11]);
            //var test14 = int.Parse(column[12]);
            //var test15 = column[13];
            //var test16 = int.Parse(column[14].Replace(" ","").Trim());
            //var test17 = column[15];
            //var test18 = column[16];

            return new Weapon
            {
                Id = id,
                WeaponName = column[0],
                WeaponType = column[1],
                Price = int.Parse(column[2].Replace("$", "").Replace(" ", "").Trim()),
                KillAward = int.Parse(column[3].Replace("$", "").Replace(" ", "").Trim()),
                Damage = int.Parse(column[4]),
                Bullets = int.Parse(column[5]),
                ArmorPenetration = double.Parse(column[6].Replace("%", "").Trim()),
                DamageFalloff = column[7],
                FireRate = double.Parse(column[8].Replace("%", "").Trim()),
                PenetrationPower = column[9],
                MagazineSize = int.Parse(column[10]),
                AmmoReserve = int.Parse(column[11]),
                Mobility = int.Parse(column[12]),
                TaggingPower = column[13],
                BulletRange = int.Parse(column[14].Replace(" ", "").Trim()),
                HoldToShoot = column[15],
                Tracers = column[16]
            };
        }
    }
}
