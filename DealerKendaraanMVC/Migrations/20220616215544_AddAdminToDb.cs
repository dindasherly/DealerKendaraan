using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealerKendaraanMVC.Migrations
{
    public partial class AddAdminToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
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
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Alamat", "Kota", "NamaBelakang", "NamaDepan", "TanggalLahir", "TanggalMasuk", "Telepon" },
                values: new object[] { 1, "jl.karimata no.8 Sumbersari", "Jember", "Afnan", "Fairuz", new DateTime(2000, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 628234692575L });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Alamat", "Kota", "NamaBelakang", "NamaDepan", "TanggalLahir", "TanggalMasuk", "Telepon" },
                values: new object[] { 2, "Jl.Adi Sucipto No.9,Tukangkayu", "Banyuwangi", "Hardiyanti", "Nafisah", new DateTime(2001, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 628527893087L });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Alamat", "Kota", "NamaBelakang", "NamaDepan", "TanggalLahir", "TanggalMasuk", "Telepon" },
                values: new object[] { 3, "Jalan raya sumber sari no. 28A", "Malang", "Putro", "Perdana", new DateTime(2001, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 628678534087L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
