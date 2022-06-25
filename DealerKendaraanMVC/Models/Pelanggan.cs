using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{
    public class Pelanggan
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nama Pelanggan")]
        public string Nama { get; set; }
        [Required]
        [DisplayName("Alamat Pelanggan")]
        public string Alamat { get; set; }
        [Required]
        [DisplayName("Kota Pelanggan")]
        public string Kota { get; set; }
        [Required]
        [DisplayName("Telepon Pelanggan")]
        public long Telepon { get; set; }
        [Required]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }

    }
}
