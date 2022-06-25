using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddTrukToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Truks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Truks",
                columns: new[] { "Id", "Description", "Nama" },
                values: new object[] { 1, null, "Puso HINO 235 PS" });

            migrationBuilder.InsertData(
                table: "Truks",
                columns: new[] { "Id", "Description", "Nama" },
                values: new object[] { 2, null, "Tronton NISSAN 215 PK" });

            migrationBuilder.InsertData(
                table: "Truks",
                columns: new[] { "Id", "Description", "Nama" },
                values: new object[] { 3, null, "Canter HINO 235 FG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Truks");
        }
    }
}
