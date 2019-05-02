using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RentalCarSystem.Models
{
    public class Companies 
    {
        
        [Key]
        public int Sirket_ID { get; set; }

        public string Sirket_Ad { get; set; }

        public string Sirket_Sehir { get; set; }

        public string Sirket_Adres { get; set; }

        public int Sirket_AracSayisi { get; set; }

        public int SirketPuan { get; set; }

        
    }

}
