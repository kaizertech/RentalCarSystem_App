using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.Models
{
    public class Car
    {
        public Car()
        {

        }
        [Key]
        public int aracId { get; set; }
        public int sirketId { get; set; }
        [StringLength(50)]
        public string marka { get; set; }
        [StringLength(50)]
        public string model { get; set; }
        public int minEhliyetYasi { get; set; }
        public short minYasSiniri { get; set; }
        public short gunlukMaxKmSiniri { get; set; }
        public int anlikKm { get; set; }
        public byte airbagSayisi { get; set; }
        public short bagajHacmi { get; set; }
        public byte koltukSayisi { get; set; }
        public int gunlukFiyat { get; set; }
    }
}
