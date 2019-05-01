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
        public int Kiralama_ID { get; set; }

        public int Musteri_id { get; set; }

        public int Araba_id { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public int VerilisKM { get; set; }

        public int  AlisKm { get; set; }

        public decimal Ucret { get; set; }


        public virtual Customers Customers { get; set; }
        public virtual Cars Cars { get; set; }
    }
}
