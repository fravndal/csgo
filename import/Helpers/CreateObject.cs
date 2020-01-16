namespace Import.Helpers
{
    using Core.Entities;

    public static class CreateObject
    {
        public static Weapon CreateWeapon(this string line, int id)
        {
            var column = line.Split(";");

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
