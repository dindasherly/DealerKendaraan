using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Models
{
    public class Truk
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nama { get; set; }
        public string Description { get; set; }

        public List<Pemasok> HandledPemasoks;
    }
}
