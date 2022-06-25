using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{
    public class Merk
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nama Merk")]
        public string Nama { get; set; }
        public string Description { get; set; }

        public List<Produk> Produks;
    }
}
