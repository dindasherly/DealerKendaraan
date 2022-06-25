using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{

    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nama Depan")]
        public string NamaDepan { get; set; }

        [Required]
        [DisplayName("Nama Belakang")]
        public string NamaBelakang { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Tanggal Lahir")]
        public DateTime TanggalLahir { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Tanggal Masuk")]
        public DateTime TanggalMasuk { get; set; }

        [Required]
        public long Telepon { get; set; }

        [Required]

        public string Alamat { get; set; }

        [Required]
        public string Kota { get; set; }

        public List<Pelanggan> ManagedPelanggans { get; set; }
        public List<Pemasok> ManagedPemasoks { get; set; }


    }
}
