﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject2020.Data.Models
{
    public class SellerInfo
    {

        public SellerInfo()
        {
            this.Deals = new HashSet<Deals>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Stores")]
        public int StoreId { get; set; }
        public Stores Stores { get; set; }

        public virtual ICollection<Deals> Deals { get; set; }

    }
}
