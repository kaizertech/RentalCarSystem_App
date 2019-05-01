using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RentalCarSystem.Models
{
    public class Transactions : BaseEntitiy
    {
        [Key]
        public int Musteri_ID { get; set; }

        public int Araba_ID { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public int VerilisKM { get; set; }

        public int  AlisKm { get; set; }

        public decimal Ucret { get; set; }

        public Customers Customers{ get; set; }

        public Cars Cars { get; set; }
    }
}
