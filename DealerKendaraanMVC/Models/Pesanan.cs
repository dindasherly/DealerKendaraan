using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{
    public class Pesanan
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime TanggalPesan { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime TanggalTiba { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime TanggalPengiriman { get; set; }

        [Required]
        [DisplayName("Nama Pelanggan")]
        public string NamaPelanggan { get; set; }

        [Required]
        [DisplayName("Alamat Pelanggan")]
        public string AlamatPelanggan { get; set; }

        [Required]
        [DisplayName("Kode Kendaraan")]
        public string KotaPelanggan { get; set; }

        public int KasirId { get; set; }
        public Kasir Kasir { get; set; }


        public List<DetailPesananItem> DetailPesanans;

    }
}
