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
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.CreateTable(
                name: "WeaponsImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponImageName = table.Column<string>(nullable: true),
                    WeaponId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponsImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponsImage_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponsImage_WeaponId",
                table: "WeaponsImage",
                column: "WeaponId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponsImage");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
