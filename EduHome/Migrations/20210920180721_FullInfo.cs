using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class FullInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bioInformation",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(maxLength: 100, nullable: false),
                    LogoImage = table.Column<string>(nullable: true),
                    FacebookLink = table.Column<string>(nullable: false),
                    PinterstLink = table.Column<string>(nullable: false),
                    VimeoLink = table.Column<string>(nullable: false),
                    TwitterLink = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(maxLength: 255, nullable: false),
                    Phone1 = table.Column<string>(maxLength: 100, nullable: false),
                    Phone2 = table.Column<string>(maxLength: 100, nullable: false),
                    EmailAdress = table.Column<string>(maxLength: 255, nullable: false),
                    WebAdress = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bioInformation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bioInformation");
        }
    }
}
