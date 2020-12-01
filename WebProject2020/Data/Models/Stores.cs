﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject2020.Data.Models
{
    public class Stores
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StoreName { get; set; }
        [Required]
        public string City { get; set; }



    }
}