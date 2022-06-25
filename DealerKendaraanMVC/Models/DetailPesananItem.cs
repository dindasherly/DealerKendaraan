using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{
    public class DetailPesananItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public float Harga { get; set; }
        [Required]
        public float Jumlah { get; set; }

        [Required]
        public int ProdukId { get; set; }
        public Produk Produk { get; set; }

        [Required]
        public int PesananId { get; set; }
        public Pesanan Pesanan { get; set; }

        [Required]
        public int KasirId { get; set; }
        public Kasir Kasir { get; set; }

    }
}
