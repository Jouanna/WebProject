using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebProject2020.Models;

namespace WebProject2020.Data.Models
{
    public class VehicleDetails
    {
        public VehicleDetails()
        {
            this.Deals = new HashSet<Deals>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Details")]
        public int DetailsId { get; set; }
        public Details Details { get; set; }

        [Required]
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public virtual ICollection<Deals> Deals { get; set; }

    }
}
