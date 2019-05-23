using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.Models
{
    public class Company
    {
        public Company()
        {
                
        }
        [Key]
        [Column(Order = 1)]
        public int sirketId { get; set; }
        [StringLength(50)]
        public string sirketAdi { get; set; }
        [StringLength(50)]
        public string sehir { get; set; }
        [StringLength(100)]
        public string adres { get; set; }
        public ushort aracSayisi { get; set; }
        public int? sirketPuani { get; set; }
    }
}
