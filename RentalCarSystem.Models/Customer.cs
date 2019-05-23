using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.Models
{
    public class Customer
    {
        [Key]
        [Column(Order = 1)]
        public int musteriId { get; set; }
        public int kullaniciId { get; set; }
        [StringLength(50)]
        public string ad { get; set; }
        [StringLength(50)]
        public string soyad { get; set; }
    }
}
