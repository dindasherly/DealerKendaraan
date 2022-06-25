using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddPesananToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pesanans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TanggalPesan = table.Column<DateTime>(nullable: false),
                    TanggalTiba = table.Column<DateTime>(nullable: false),
                    TanggalPengiriman = table.Column<DateTime>(nullable: false),
                    NamaPelanggan = table.Column<string>(nullable: false),
                    AlamatPelanggan = table.Column<string>(nullable: false),
                    KotaPelanggan = table.Column<string>(nullable: false),
                    KasirId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesanans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pesanans_Kasirs_KasirId",
                        column: x => x.KasirId,
                        principalTable: "Kasirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pesanans",
                columns: new[] { "Id", "AlamatPelanggan", "KasirId", "KotaPelanggan", "NamaPelanggan", "TanggalPengiriman", "TanggalPesan", "TanggalTiba" },
                values: new object[] { 1, "jl.danau buyan", 1, "Denpasar", "Ahmad Aziz", new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Pesanans",
                columns: new[] { "Id", "AlamatPelanggan", "KasirId", "KotaPelanggan", "NamaPelanggan", "TanggalPengiriman", "TanggalPesan", "TanggalTiba" },
                values: new object[] { 2, "jl.mendut no.15", 3, "Banyuwangi", "Arisandi", new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Pesanans",
                columns: new[] { "Id", "AlamatPelanggan", "KasirId", "KotaPelanggan", "NamaPelanggan", "TanggalPengiriman", "TanggalPesan", "TanggalTiba" },
                values: new object[] { 3, "perum jember permai 3", 2, "Jember", "Heri", new DateTime(2020, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Pesanans_KasirId",
                table: "Pesanans",
                column: "KasirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pesanans");
        }
    }
}
