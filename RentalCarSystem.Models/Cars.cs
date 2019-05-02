using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RentalCarSystem.Models
{
    public class Cars 
    {
       
        [Key]
        public int Araba_ID { get; set; }

        public int Sirket_id { get; set; }

        public string Araba_Ad { get; set; }

        public string Araba_Model { get; set; }

        public int Araba_GunlukKmSiniri { get; set; }

        public bool Araba_AirBag { get; set; }

        public int Araba_BagajHacmi { get; set; }

        public int Araba_KoltukSayisi { get; set; }

        public int Araba_GunlukKira { get; set; }

        

    }
}
