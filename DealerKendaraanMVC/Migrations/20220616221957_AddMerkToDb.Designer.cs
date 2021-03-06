// <auto-generated />
using System;
using DealerKendaraanMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DealerKendaraanMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220616221957_AddMerkToDb")]
    partial class AddMerkToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DealerKendaraanMVC.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alamat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaBelakang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaDepan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TanggalMasuk")
                        .HasColumnType("datetime2");

                    b.Property<long>("Telepon")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alamat = "jl.karimata no.8 Sumbersari",
                            Kota = "Jember",
                            NamaBelakang = "Afnan",
                            NamaDepan = "Fairuz",
                            TanggalLahir = new DateTime(2000, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalMasuk = new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Telepon = 628234692575L
                        },
                        new
                        {
                            Id = 2,
                            Alamat = "Jl.Adi Sucipto No.9,Tukangkayu",
                            Kota = "Banyuwangi",
                            NamaBelakang = "Hardiyanti",
                            NamaDepan = "Nafisah",
                            TanggalLahir = new DateTime(2001, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalMasuk = new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Telepon = 628527893087L
                        },
                        new
                        {
                            Id = 3,
                            Alamat = "Jalan raya sumber sari no. 28A",
                            Kota = "Malang",
                            NamaBelakang = "Putro",
                            NamaDepan = "Perdana",
                            TanggalLahir = new DateTime(2001, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalMasuk = new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Telepon = 628678534087L
                        });
                });

            modelBuilder.Entity("DealerKendaraanMVC.Models.Kasir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alamat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaBelakang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaDepan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TanggalMasuk")
                        .HasColumnType("datetime2");

                    b.Property<long>("Telepon")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Kasirs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alamat = "jl.kepiting tukangkayu",
                            Kota = "Jember",
                            NamaBelakang = "Khusnul",
                            NamaDepan = "Eni",
                            TanggalLahir = new DateTime(2002, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalMasuk = new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Telepon = 6281239578435L
                        },
                        new
                        {
                            Id = 2,
                            Alamat = "jl.kertanegara barat iv",
                            Kota = "Malang",
                            NamaBelakang = "Binsar",
                            NamaDepan = "Joel",
                            TanggalLahir = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalMasuk = new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Telepon = 6285267356790L
                        },
                        new
                        {
                            Id = 3,
                            Alamat = "rnardy land, puring",
                            Kota = "Banyuwangi",
                            NamaBelakang = "Dwi",
                            NamaDepan = "Diki",
                            TanggalLahir = new DateTime(2000, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TanggalMasuk = new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Telepon = 62821216894321L
                        });
                });

            modelBuilder.Entity("DealerKendaraanMVC.Models.Merk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Merks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nama = "Honda"
                        },
                        new
                        {
                            Id = 2,
                            Nama = "Suzuki"
                        },
                        new
                        {
                            Id = 3,
                            Nama = "Yamaha"
                        });
                });

            modelBuilder.Entity("DealerKendaraanMVC.Models.Pelanggan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telepon")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Pelanggans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminId = 3,
                            Alamat = "Jl. Danau Buyan Iv/ 15, Sanur",
                            Kota = "Denpasar",
                            Nama = "Ahmad Aziz",
                            Telepon = 628456654898L
                        },
                        new
                        {
                            Id = 2,
                            AdminId = 2,
                            Alamat = "Jl. Mendut No.85, Taman Baru",
                            Kota = "Banyuangi",
                            Nama = "Arisandi",
                            Telepon = 628029542745L
                        },
                        new
                        {
                            Id = 3,
                            AdminId = 2,
                            Alamat = "perum.jember permai 3 blok P-1",
                            Kota = "Jember",
                            Nama = "Heri",
                            Telepon = 628620970885L
                        });
                });

            modelBuilder.Entity("DealerKendaraanMVC.Models.Pelanggan", b =>
                {
                    b.HasOne("DealerKendaraanMVC.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
