﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.Models
{
    public class Person
    {
        [Key]
        [Column(Order = 1)]
        public int calisanId { get; set; }
        [StringLength(50)]
        public string ad { get; set; }
        [StringLength(50)]
        public string soyad { get; set; }
        public int sirketId { get; set; }
        public int kullaniciId { get; set; }
    }
}
