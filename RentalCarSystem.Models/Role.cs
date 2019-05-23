using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.Models
{
    public class Role
    {
        [Key]
        public int rolid { get; set; }
        [StringLength(50)]
        public string rolAdı { get; set; }
    }
}
