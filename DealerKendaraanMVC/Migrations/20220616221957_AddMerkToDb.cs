using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddMerkToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Merks",
                columns: new[] { "Id", "Description", "Nama" },
                values: new object[] { 1, null, "Honda" });

            migrationBuilder.InsertData(
                table: "Merks",
                columns: new[] { "Id", "Description", "Nama" },
                values: new object[] { 2, null, "Suzuki" });

            migrationBuilder.InsertData(
                table: "Merks",
                columns: new[] { "Id", "Description", "Nama" },
                values: new object[] { 3, null, "Yamaha" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merks");
        }
    }
}
