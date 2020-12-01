using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject2020.Data.Models
{
    public class BuyerInfo
    {
        public BuyerInfo()
        {
            this.Deals = new HashSet<Deals>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Deals> Deals { get; set; }

    }
}
