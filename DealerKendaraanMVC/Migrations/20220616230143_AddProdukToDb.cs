using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddProdukToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(nullable: false),
                    Warna = table.Column<string>(nullable: false),
                    HargaSatuan = table.Column<float>(nullable: false),
                    StokBarang = table.Column<int>(nullable: false),
                    Gambar = table.Column<byte[]>(nullable: true),
                    MerkId = table.Column<int>(nullable: false),
                    PemasokId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produks_Merks_MerkId",
                        column: x => x.MerkId,
                        principalTable: "Merks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produks_Pemasoks_PemasokId",
                        column: x => x.PemasokId,
                        principalTable: "Pemasoks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Produks",
                columns: new[] { "Id", "Gambar", "HargaSatuan", "MerkId", "Nama", "PemasokId", "StokBarang", "Warna" },
                values: new object[] { 1, null, 250000000f, 1, "Cb 100R", 1, 7, "Merah Hitam" });

            migrationBuilder.InsertData(
                table: "Produks",
                columns: new[] { "Id", "Gambar", "HargaSatuan", "MerkId", "Nama", "PemasokId", "StokBarang", "Warna" },
                values: new object[] { 2, null, 750000000f, 2, "Suz GSX-150", 2, 5, "Biru" });

            migrationBuilder.InsertData(
                table: "Produks",
                columns: new[] { "Id", "Gambar", "HargaSatuan", "MerkId", "Nama", "PemasokId", "StokBarang", "Warna" },
                values: new object[] { 3, null, 20000000f, 3, "Vixion 150", 3, 5, "Hitam" });

            migrationBuilder.CreateIndex(
                name: "IX_Produks_MerkId",
                table: "Produks",
                column: "MerkId");

            migrationBuilder.CreateIndex(
                name: "IX_Produks_PemasokId",
                table: "Produks",
                column: "PemasokId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produks");
        }
    }
}
