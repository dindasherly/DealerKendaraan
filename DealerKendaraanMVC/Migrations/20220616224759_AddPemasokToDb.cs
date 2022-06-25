using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddPemasokToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kota",
                table: "Admins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alamat",
                table: "Admins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Pemasoks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaPerusahaaan = table.Column<string>(nullable: false),
                    NamaKontak = table.Column<string>(nullable: false),
                    Alamat = table.Column<string>(nullable: false),
                    Kota = table.Column<string>(nullable: false),
                    Telepon = table.Column<long>(nullable: false),
                    TrukId = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pemasoks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pemasoks_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pemasoks_Truks_TrukId",
                        column: x => x.TrukId,
                        principalTable: "Truks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pemasoks",
                columns: new[] { "Id", "AdminId", "Alamat", "Kota", "NamaKontak", "NamaPerusahaaan", "Telepon", "TrukId" },
                values: new object[] { 1, 1, "Soekarno-Hatta No.3", "Bandung", "John Sibuea", "PT.Honda Bng", 628674356391L, 2 });

            migrationBuilder.InsertData(
                table: "Pemasoks",
                columns: new[] { "Id", "AdminId", "Alamat", "Kota", "NamaKontak", "NamaPerusahaaan", "Telepon", "TrukId" },
                values: new object[] { 2, 2, "jl.pranoto, petojo sel.", "Jakarta", "Melia", "PT.Legenda Motor", 628653567320L, 3 });

            migrationBuilder.InsertData(
                table: "Pemasoks",
                columns: new[] { "Id", "AdminId", "Alamat", "Kota", "NamaKontak", "NamaPerusahaaan", "Telepon", "TrukId" },
                values: new object[] { 3, 3, "Jl. Cokroaminoto No.80", "Bandung", "Basri", "PT. Astra Motor", 628379054124L, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Pemasoks_AdminId",
                table: "Pemasoks",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Pemasoks_TrukId",
                table: "Pemasoks",
                column: "TrukId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pemasoks");

            migrationBuilder.AlterColumn<string>(
                name: "Kota",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Alamat",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
