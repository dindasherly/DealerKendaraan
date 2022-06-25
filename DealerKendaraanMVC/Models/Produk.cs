using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{
    public class Produk
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Kode Kendaraan")]
        public string Nama { get; set; }

        [Required]
        public string Warna { get; set; }

        [Required]
        [DisplayName("Harga")]
        public float HargaSatuan { get; set; }

        [Required]
        [DisplayName("Stok")]
        public int StokBarang { get; set; }


        public byte[] Gambar { get; set; }

        [Required]
        public int MerkId { get; set; }
        public Merk Merk { get; set; }

        [Required]
        public int PemasokId { get; set; }
        public Pemasok Pemasok { get; set; }


        public List<DetailPesananItem> InPesanans;
    }
}
