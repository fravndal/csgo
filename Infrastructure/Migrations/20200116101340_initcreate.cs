using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WeaponName = table.Column<string>(nullable: true),
                    WeaponType = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    KillAward = table.Column<int>(nullable: false),
                    Damage = table.Column<int>(nullable: false),
                    Bullets = table.Column<int>(nullable: false),
                    ArmorPenetration = table.Column<double>(nullable: false),
                    DamageFalloff = table.Column<string>(nullable: true),
                    FireRate = table.Column<double>(nullable: false),
                    PenetrationPower = table.Column<string>(nullable: true),
                    MagazineSize = table.Column<int>(nullable: false),
                    AmmoReserve = table.Column<int>(nullable: false),
                    Mobility = table.Column<int>(nullable: false),
                    TaggingPower = table.Column<string>(nullable: true),
                    BulletRange = table.Column<int>(nullable: false),
                    HoldToShoot = table.Column<string>(nullable: true),
                    Tracers = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
