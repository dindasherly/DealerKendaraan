using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddDetailPesananToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailPesananItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Harga = table.Column<float>(nullable: false),
                    Jumlah = table.Column<float>(nullable: false),
                    ProdukId = table.Column<int>(nullable: false),
                    PesananId = table.Column<int>(nullable: false),
                    KasirId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailPesananItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailPesananItem_Kasirs_KasirId",
                        column: x => x.KasirId,
                        principalTable: "Kasirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailPesananItem_Pesanans_PesananId",
                        column: x => x.PesananId,
                        principalTable: "Pesanans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailPesananItem_Produks_ProdukId",
                        column: x => x.ProdukId,
                        principalTable: "Produks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DetailPesananItem",
                columns: new[] { "Id", "Harga", "Jumlah", "KasirId", "PesananId", "ProdukId" },
                values: new object[] { 1, 20000000f, 1f, 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "DetailPesananItem",
                columns: new[] { "Id", "Harga", "Jumlah", "KasirId", "PesananId", "ProdukId" },
                values: new object[] { 2, 750000000f, 1f, 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "DetailPesananItem",
                columns: new[] { "Id", "Harga", "Jumlah", "KasirId", "PesananId", "ProdukId" },
                values: new object[] { 3, 250000000f, 1f, 3, 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_DetailPesananItem_KasirId",
                table: "DetailPesananItem",
                column: "KasirId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailPesananItem_PesananId",
                table: "DetailPesananItem",
                column: "PesananId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailPesananItem_ProdukId",
                table: "DetailPesananItem",
                column: "ProdukId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailPesananItem");
        }
    }
}
