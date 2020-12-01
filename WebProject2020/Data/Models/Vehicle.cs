using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject2020.Data.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            this.VehiclesDetails = new HashSet<VehicleDetails>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string BrandName { get; set; }

        public ICollection<VehicleDetails> VehiclesDetails { get; set; }

    }
}
