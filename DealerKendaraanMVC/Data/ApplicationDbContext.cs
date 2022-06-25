using DealerKendaraanMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Pelanggan> Pelanggans { get; set; }
        public DbSet<Kasir> Kasirs { get; set; }
        public DbSet<Merk> Merks { get; set; }
        public DbSet<Truk> Truks { get; set; }
        public DbSet<Pemasok> Pemasoks { get; set; }

        public DbSet<Produk> Produks { get; set; }
        public DbSet<Pesanan> Pesanans { get; set; }

        public DbSet<DetailPesananItem> DetailPesanans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Admin>().HasIndex(b => b.Telepon).IsUnique();
            modelBuilder.Entity<Kasir>().HasIndex(b => b.Telepon).IsUnique();
            modelBuilder.Entity<Pelanggan>().HasIndex(b => b.Telepon).IsUnique();
            modelBuilder.Entity<Pemasok>().HasIndex(b => b.Telepon).IsUnique();

            modelBuilder.Entity<Admin>().HasData(
                    new Admin
                    {
                        Id = 1,
                        NamaDepan = "Fairuz",
                        NamaBelakang = "Afnan",
                        Alamat = "jl.karimata no.8 Sumbersari",
                        Kota = "Jember",
                        Telepon = 628234692575,
                        TanggalLahir = DateTime.ParseExact("08-08-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalMasuk = DateTime.ParseExact("12-05-2017", "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    },
                    new Admin
                    {
                        Id = 2,
                        NamaDepan = "Nafisah",
                        NamaBelakang = "Hardiyanti",
                        Alamat = "Jl.Adi Sucipto No.9,Tukangkayu",
                        Kota = "Banyuwangi",
                        Telepon = 628527893087,
                        TanggalLahir = DateTime.ParseExact("12-04-2001", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalMasuk = DateTime.ParseExact("23-04-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    },
                    new Admin
                    {
                        Id = 3,
                        NamaDepan = "Perdana",
                        NamaBelakang = "Putro",
                        Alamat = "Jalan raya sumber sari no. 28A",
                        Kota = "Malang",
                        Telepon = 628678534087,
                        TanggalLahir = DateTime.ParseExact("05-03-2001", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalMasuk = DateTime.ParseExact("05-05-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    }
                );


            modelBuilder.Entity<Pelanggan>()
                .HasData(
                    new Pelanggan
                    {
                        Id = 1,
                        Nama = "Ahmad Aziz",
                        Alamat = "Jl. Danau Buyan Iv/ 15, Sanur",
                        Telepon = 628456654898,
                        Kota = "Denpasar",
                        AdminId = 3,
                    },
                    new Pelanggan
                    {
                        Id = 2,
                        Nama = "Arisandi",
                        Alamat = "Jl. Mendut No.85, Taman Baru",
                        Telepon = 628029542745,
                        Kota = "Banyuangi",
                        AdminId = 2,
                    },
                    new Pelanggan
                    {
                        Id = 3,
                        Nama = "Heri",
                        Alamat = "perum.jember permai 3 blok P-1",
                        Telepon = 628620970885,
                        Kota = "Jember",
                        AdminId = 2,
                    }
                );

            modelBuilder.Entity<Kasir>().HasData(
                    new Kasir
                    {
                        Id = 1,
                        NamaDepan = "Eni",
                        NamaBelakang = "Khusnul",
                        Alamat = "jl.kepiting tukangkayu",
                        Kota = "Jember",
                        Telepon = 6281239578435,
                        TanggalLahir = DateTime.ParseExact("02-03-2002", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalMasuk = DateTime.ParseExact("05-06-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    },
                    new Kasir
                    {
                        Id = 2,
                        NamaDepan = "Joel",
                        NamaBelakang = "Binsar",
                        Alamat = "jl.kertanegara barat iv",
                        Kota = "Malang",
                        Telepon = 6285267356790,
                        TanggalLahir = DateTime.ParseExact("01-01-2001", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalMasuk = DateTime.ParseExact("20-04-2018", "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    },
                    new Kasir
                    {
                        Id = 3,
                        NamaDepan = "Diki",
                        NamaBelakang = "Dwi",
                        Alamat = "rnardy land, puring",
                        Kota = "Banyuwangi",
                        Telepon = 62821216894321,
                        TanggalLahir = DateTime.ParseExact("13-07-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalMasuk = DateTime.ParseExact("15-02-2017", "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    }
                );

            modelBuilder.Entity<Merk>().HasData(
                    new Merk
                    {
                        Id = 1,
                        Nama = "Honda",
                    },
                    new Merk
                    {
                        Id = 2,
                        Nama = "Suzuki",
                    },
                    new Merk
                    {
                        Id = 3,
                        Nama = "Yamaha",
                    }
                );

            modelBuilder.Entity<Truk>().HasData(
                    new Truk
                    {
                        Id = 1,
                        Nama = "Puso HINO 235 PS",
                    },
                    new Truk
                    {
                        Id = 2,
                        Nama = "Tronton NISSAN 215 PK",
                    },
                    new Truk
                    {
                        Id = 3,
                        Nama = "Canter HINO 235 FG",
                    }
                );

            modelBuilder.Entity<Pemasok>().HasData(
                    new Pemasok
                    {
                        Id = 1,
                        NamaPerusahaaan = "PT.Honda Bng",
                        NamaKontak = "John Sibuea",
                        Alamat = "Soekarno-Hatta No.3",
                        Kota = "Bandung",
                        Telepon = 628674356391,
                        AdminId = 1,
                        TrukId = 2
                    },
                    new Pemasok
                    {
                        Id = 2,
                        NamaPerusahaaan = "PT.Legenda Motor",
                        NamaKontak = "Melia",
                        Alamat = "jl.pranoto, petojo sel.",
                        Kota = "Jakarta",
                        Telepon = 628653567320,
                        AdminId = 2,
                        TrukId = 3
                    },
                    new Pemasok
                    {
                        Id = 3,
                        NamaPerusahaaan = "PT. Astra Motor",
                        NamaKontak = "Basri",
                        Alamat = "Jl. Cokroaminoto No.80",
                        Kota = "Bandung",
                        Telepon = 628379054124,
                        AdminId = 3,
                        TrukId = 1
                    }
                );
            modelBuilder.Entity<Produk>().HasData(
                    new Produk
                    {
                        Id = 1,
                        Nama = "Cb 100R",
                        Warna = "Merah Hitam",
                        HargaSatuan = 250000000,
                        StokBarang = 7,
                        PemasokId = 1,
                        MerkId = 1
                    },
                    new Produk
                    {
                        Id = 2,
                        Nama = "Suz GSX-150",
                        Warna = "Biru",
                        HargaSatuan = 750000000,
                        StokBarang = 5,
                        PemasokId = 2,
                        MerkId = 2
                    },
                    new Produk
                    {
                        Id = 3,
                        Nama = "Vixion 150",
                        Warna = "Hitam",
                        HargaSatuan = 20000000,
                        StokBarang = 5,
                        PemasokId = 3,
                        MerkId = 3
                    }
                );


            // Id, TanggalPesanan, TangalTiba, TanggalPengiriman, NamaPelanggan,  KotaPelanggan, AlamatPelanggan, KasirId, 
            // INSERT INTO pesanan VALUES(1,'08-02-2019','16-02-2019','2019-02-15','Ahmad Aziz','Denpasar','jl.danau buyan',1)
            // INSERT INTO pesanan VALUES(2,'15-05-2019','27-05-2019','2019-05-27','Arisandi','Banyuwangi','jl.mendut no.15',3)
            // INSERT INTO pesanan VALUES(3,'20-08-2020','28-08-2020','2020-08-27','Heri','Jember','perum jember permai 3',2)

            modelBuilder.Entity<Pesanan>().HasData(
                    new Pesanan
                    {
                        Id = 1,
                        TanggalPesan = DateTime.ParseExact("08-02-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalTiba = DateTime.ParseExact("16-02-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalPengiriman = DateTime.ParseExact("2019-02-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        NamaPelanggan = "Ahmad Aziz",
                        KotaPelanggan = "Denpasar",
                        AlamatPelanggan = "jl.danau buyan",
                        KasirId = 1
                    },
                    new Pesanan
                    {
                        Id = 2,
                        TanggalPesan = DateTime.ParseExact("15-05-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalTiba = DateTime.ParseExact("27-05-2019", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalPengiriman = DateTime.ParseExact("2019-05-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        NamaPelanggan = "Arisandi",
                        KotaPelanggan = "Banyuwangi",
                        AlamatPelanggan = "jl.mendut no.15",
                        KasirId = 3
                    },
                    new Pesanan
                    {
                        Id = 3,
                        TanggalPesan = DateTime.ParseExact("20-08-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalTiba = DateTime.ParseExact("28-08-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TanggalPengiriman = DateTime.ParseExact("2020-08-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        NamaPelanggan = "Heri",
                        KotaPelanggan = "Jember",
                        AlamatPelanggan = "perum jember permai 3",
                        KasirId = 2
                    }
            );


            // Id, PesananId, ProdukId, KasirId, Harga, Jumlah
            // INSERT INTO detail_pesanan VALUES (1,1,3,1,20000000,1)
            // INSERT INTO detail_pesanan VALUES (2,2,2,2,750000000,1)
            // INSERT INTO detail_pesanan VALUES (3,3,1,3,250000000,1)

            modelBuilder.Entity<DetailPesananItem>().HasData(
                    new DetailPesananItem
                    {
                        Id = 1,
                        PesananId = 1,
                        ProdukId = 3,
                        KasirId = 1,
                        Harga = 20000000,
                        Jumlah = 1
                    },
                    new DetailPesananItem
                    {
                        Id = 2,
                        PesananId = 2,
                        ProdukId = 2,
                        KasirId = 2,
                        Harga = 750000000,
                        Jumlah = 1
                    },
                    new DetailPesananItem
                    {
                        Id = 3,
                        PesananId = 3,
                        ProdukId = 1,
                        KasirId = 3,
                        Harga = 250000000,
                        Jumlah = 1
                    }
                );
        }
    }
}
