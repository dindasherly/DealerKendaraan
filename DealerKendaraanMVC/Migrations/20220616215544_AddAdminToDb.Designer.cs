﻿// <auto-generated />
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
    [Migration("20220616215544_AddAdminToDb")]
    partial class AddAdminToDb
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
#pragma warning restore 612, 618
        }
    }
}