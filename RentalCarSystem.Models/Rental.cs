using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.Models
{
    public class Rental
    {
        [Key]
        [Column(Order = 1)]
        public int kiralamaId { get; set; }
        public int sirketId { get; set; }
        public int musteriId { get; set; }
        public int aracId { get; set; }
        public DateTime verilisTarihi { get; set; }
        public DateTime? geriAlisTarihi { get; set; }
        public int verilisKm { get; set; }
        public int? sonKm { get; set; }
        public int? ucret { get; set; }
    }
}
