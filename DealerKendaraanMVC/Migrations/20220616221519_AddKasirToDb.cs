using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddKasirToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kasirs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaDepan = table.Column<string>(nullable: false),
                    NamaBelakang = table.Column<string>(nullable: false),
                    TanggalLahir = table.Column<DateTime>(nullable: false),
                    TanggalMasuk = table.Column<DateTime>(nullable: false),
                    Telepon = table.Column<long>(nullable: false),
                    Alamat = table.Column<string>(nullable: true),
                    Kota = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasirs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kasirs",
                columns: new[] { "Id", "Alamat", "Kota", "NamaBelakang", "NamaDepan", "TanggalLahir", "TanggalMasuk", "Telepon" },
                values: new object[] { 1, "jl.kepiting tukangkayu", "Jember", "Khusnul", "Eni", new DateTime(2002, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6281239578435L });

            migrationBuilder.InsertData(
                table: "Kasirs",
                columns: new[] { "Id", "Alamat", "Kota", "NamaBelakang", "NamaDepan", "TanggalLahir", "TanggalMasuk", "Telepon" },
                values: new object[] { 2, "jl.kertanegara barat iv", "Malang", "Binsar", "Joel", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6285267356790L });

            migrationBuilder.InsertData(
                table: "Kasirs",
                columns: new[] { "Id", "Alamat", "Kota", "NamaBelakang", "NamaDepan", "TanggalLahir", "TanggalMasuk", "Telepon" },
                values: new object[] { 3, "rnardy land, puring", "Banyuwangi", "Dwi", "Diki", new DateTime(2000, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 62821216894321L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kasirs");
        }
    }
}
