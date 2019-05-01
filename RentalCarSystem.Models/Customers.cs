using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RentalCarSystem.Models
{
    public class Customers
    {
        public Customers()
        {
            Transactions = new List<Transactions>();
        }
        [Key]
        public int Musteri_ID { get; set; }

        public string Musteri_Ad { get; set; }

        public string  Musteri_Soyad { get; set; }

        public string Musteri_TC { get; set; }

        public string Musteri_KullaniciAdi { get; set; }

        public string Musteri_Sifre { get; set; }

        public ICollection<Transactions> Transactions { get; set; }

    }
}
