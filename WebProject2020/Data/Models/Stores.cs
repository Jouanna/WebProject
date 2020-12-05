using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProject2020.Models;

namespace WebProject2020.Data.Models
{
    public class Stores
    {
        public Stores()
        {
            this.SellersInfo = new HashSet<SellerInfo>();
            this.Cars = new HashSet<Details>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string StoreName { get; set; }
        [Required]
        public string City { get; set; }

        public string Address { get; set; }

        public virtual ICollection<SellerInfo> SellersInfo { get; set; }

        public virtual ICollection<Details> Cars { get; set; }



    }
}
