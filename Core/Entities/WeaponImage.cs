namespace Core.Entities
{
    public class WeaponImage : BaseEntity
    {
        public string WeaponImageName { get; set; }
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}
