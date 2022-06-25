using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddConstraintsToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pemasoks_Telepon",
                table: "Pemasoks",
                column: "Telepon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pelanggans_Telepon",
                table: "Pelanggans",
                column: "Telepon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kasirs_Telepon",
                table: "Kasirs",
                column: "Telepon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Telepon",
                table: "Admins",
                column: "Telepon",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pemasoks_Telepon",
                table: "Pemasoks");

            migrationBuilder.DropIndex(
                name: "IX_Pelanggans_Telepon",
                table: "Pelanggans");

            migrationBuilder.DropIndex(
                name: "IX_Kasirs_Telepon",
                table: "Kasirs");

            migrationBuilder.DropIndex(
                name: "IX_Admins_Telepon",
                table: "Admins");
        }
    }
}
