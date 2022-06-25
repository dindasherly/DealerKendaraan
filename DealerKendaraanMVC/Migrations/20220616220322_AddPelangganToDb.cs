using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddPelangganToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pelanggans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(nullable: false),
                    Alamat = table.Column<string>(nullable: false),
                    Kota = table.Column<string>(nullable: false),
                    Telepon = table.Column<long>(nullable: false),
                    AdminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelanggans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pelanggans_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pelanggans",
                columns: new[] { "Id", "AdminId", "Alamat", "Kota", "Nama", "Telepon" },
                values: new object[] { 1, 3, "Jl. Danau Buyan Iv/ 15, Sanur", "Denpasar", "Ahmad Aziz", 628456654898L });

            migrationBuilder.InsertData(
                table: "Pelanggans",
                columns: new[] { "Id", "AdminId", "Alamat", "Kota", "Nama", "Telepon" },
                values: new object[] { 2, 2, "Jl. Mendut No.85, Taman Baru", "Banyuangi", "Arisandi", 628029542745L });

            migrationBuilder.InsertData(
                table: "Pelanggans",
                columns: new[] { "Id", "AdminId", "Alamat", "Kota", "Nama", "Telepon" },
                values: new object[] { 3, 2, "perum.jember permai 3 blok P-1", "Jember", "Heri", 628620970885L });

            migrationBuilder.CreateIndex(
                name: "IX_Pelanggans_AdminId",
                table: "Pelanggans",
                column: "AdminId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pelanggans");
        }
    }
}
