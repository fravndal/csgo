using System.Collections.Generic;

namespace Core.Entities
{
    public class Weapon : BaseEntity
    {
        public string WeaponName { get; set; }
        public string WeaponType { get; set; }
        public int Price { get; set; }
        public int KillAward { get; set; }
        public int Damage { get; set; }
        public int Bullets { get; set; }
        public double ArmorPenetration { get; set; }
        public string DamageFalloff { get; set; }
        public double FireRate { get; set; }
        public string PenetrationPower { get; set; }
        public int MagazineSize { get; set; }
        public int AmmoReserve { get; set; }
        public int Mobility { get; set; }
        public string TaggingPower { get; set; }
        public int BulletRange { get; set; }
        public string HoldToShoot { get; set; }
        public string Tracers { get; set; }
        public string Slug { get; set; }
        public WeaponImage WeaponImage { get; set; }
    }
}
