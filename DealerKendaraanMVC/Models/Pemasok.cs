using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{
    public class Pemasok
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nama Perusahaan")]
        public string NamaPerusahaaan { get; set; }

        [Required]
        [DisplayName("Nama Kontak")]
        public string NamaKontak { get; set; }

        [Required]
        public string Alamat { get; set; }

        [Required]
        public string Kota { get; set; }

        [Required]
        public long Telepon { get; set; }

        public int TrukId { get; set; }
        public Truk Truk { get; set; }

        public int AdminId { get; set; }
        public Admin Admin { get; set; }


        public List<Produk> Produks;
    }
}
