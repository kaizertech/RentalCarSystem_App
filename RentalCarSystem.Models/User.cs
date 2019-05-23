using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.Models
{
    public class User
    {
        [Key]
        [Column(Order = 1)]
        public int kullaniciId { get; set; }
        [StringLength(50)]
        public string kullaniciAd { get; set; }
        [StringLength(50)]
        public string parola { get; set; }
        public int rolid { get; set; }
    }
}
